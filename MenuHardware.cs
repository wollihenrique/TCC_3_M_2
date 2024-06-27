using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCC_3_M
{
    public partial class frm_CadastroDisp : Form
    {
        private MySqlConnection connection;
        private DataTable dataTable;
        private DataRow selectedHardware;
        private int tenantId;
        private string connectionString = "server=localhost;database=inventory_system;user=root;password=etec";

        public frm_CadastroDisp(string emailDoAdministradorLogado, int tenantId)
        {
            InitializeComponent();
            this.tenantId = tenantId;

            // Adicionando tratamento de exceções para inicialização
            try
            {
                InitializeDatabaseConnection();
                LoadHardwareData();
                SetupComboBoxes();
                txtTag.TextChanged += txtTag_TextChanged;
                cmbUsuario.SelectedIndexChanged += cmbUsuario_SelectedIndexChanged; // Vincular evento de seleção
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na inicialização do formulário: " + ex.Message);
            }
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void LoadHardwareData(string orderBy = "", string statusFilter = "", string userFilter = "")
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = @"
                    SELECT h.tag, h.assurance, h.model, h.brand, h.status, h.processor, h.ram, h.disk, h.video_card, h.network_card, h.observations, h.batch_id, b.entering_date,
                           COALESCE(u.name, a.name) AS user_name
                    FROM hardware h
                    JOIN batch b ON h.batch_id = b.id
                    LEFT JOIN entity_user_hardware_peripherals euhp ON h.tag = euhp.hardware_tag
                    LEFT JOIN user u ON euhp.user_id = u.id
                    LEFT JOIN entity_admin_hardware_peripherals eahp ON h.tag = eahp.hardware_tag
                    LEFT JOIN admin a ON eahp.admin_id = a.id
                    WHERE h.tenant_id = @tenantId";

                if (!string.IsNullOrEmpty(statusFilter))
                {
                    query += " AND h.status = @status";
                }

                if (!string.IsNullOrEmpty(userFilter))
                {
                    query += " AND (u.name = @UserName OR a.name = @UserName)";
                }

                if (orderBy == "Mais recentes")
                {
                    query += " ORDER BY b.entering_date DESC";
                }
                else if (orderBy == "Mais antigos")
                {
                    query += " ORDER BY b.entering_date ASC";
                }
                else if (orderBy == "Este mês")
                {
                    query += " AND MONTH(b.entering_date) = MONTH(CURDATE()) AND YEAR(b.entering_date) = YEAR(CURDATE())";
                }
                else if (orderBy == "Este ano")
                {
                    query += " AND YEAR(b.entering_date) = YEAR(CURDATE())";
                }

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@tenantId", tenantId);

                if (!string.IsNullOrEmpty(statusFilter))
                {
                    cmd.Parameters.AddWithValue("@status", statusFilter);
                }

                if (!string.IsNullOrEmpty(userFilter))
                {
                    cmd.Parameters.AddWithValue("@UserName", userFilter);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Adiciona uma nova coluna para o lote se ainda não existir
                if (!dataTable.Columns.Contains("Lote"))
                {
                    DataColumn column = new DataColumn("Lote", typeof(string));
                    dataTable.Columns.Add(column);
                }

                // Preenche a coluna do lote com os dados
                foreach (DataRow row in dataTable.Rows)
                {
                    row["Lote"] = row["batch_id"].ToString();
                }

                dgvHardware.DataSource = dataTable; // Configura o DataSource do DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void LoadUserComboBox()
        {
            cmbUsuario.Items.Clear();
            string query = "SELECT name FROM `admin` WHERE tenant_id = @TenantId " +
                           "UNION " +
                           "SELECT name FROM `user` WHERE tenant_id = @TenantId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenantId", tenantId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string userName = reader["name"].ToString();
                        cmbUsuario.Items.Add(userName);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao preencher ComboBox de usuários: " + ex.Message);
                }
            }
        }

        private void SetupComboBoxes()
        {
            cmbOrderBy.Items.Add("Mais recentes");
            cmbOrderBy.Items.Add("Mais antigos");
            cmbOrderBy.Items.Add("Este mês");
            cmbOrderBy.Items.Add("Este ano");
            cmbOrderBy.SelectedIndexChanged += cmbOrderBy_SelectedIndexChanged;

            cmbUsuario.SelectedIndexChanged += cmbUsuario_SelectedIndexChanged;

            cmbStatus.Items.Add("Em Uso");
            cmbStatus.Items.Add("Estoque");
            cmbStatus.Items.Add("Manutenção");
            cmbStatus.Items.Add("Defeituoso");
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;

            // Carregar os usuários na ComboBox de usuários
            LoadUserComboBox();

            // Limpar seleção inicial da ComboBox de usuários
            cmbUsuario.SelectedIndex = -1;
        }

        private void cmbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOrder = cmbOrderBy.SelectedItem?.ToString() ?? "";
            string selectedStatus = cmbStatus.SelectedItem?.ToString() ?? "";
            LoadHardwareData(selectedOrder, selectedStatus);
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cmbStatus.SelectedItem?.ToString() ?? "";
            string selectedOrder = cmbOrderBy.SelectedItem?.ToString() ?? "";
            LoadHardwareData(selectedOrder, selectedStatus);

            if (selectedStatus != "Em Uso")
            {
                cmbUsuario.SelectedIndex = -1; // Limpa a seleção da ComboBox de usuários
                cmbUsuario.Enabled = false; // Desabilita a ComboBox de usuários
            }
            else
            {
                cmbUsuario.Enabled = true; // Habilita a ComboBox de usuários
            }
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedIndex >= 0) // Verifica se algum usuário está selecionado
            {
                string userName = cmbUsuario.SelectedItem.ToString();
                LoadHardwareData("", "", userName);
            }
            else
            {
                // Se nenhum usuário estiver selecionado, carrega os dados sem filtro de usuário
                LoadHardwareData();
            }
        }

        private void dgvHardware_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHardware.SelectedRows.Count > 0)
            {
                selectedHardware = ((DataRowView)dgvHardware.SelectedRows[0].DataBoundItem).Row;
            }
        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {
            string tagFilter = txtTag.Text.Trim();
            DataView dv = new DataView(dataTable);
            dv.RowFilter = $"tag LIKE '%{tagFilter}%'";
            dgvHardware.DataSource = dv;
        }

        private void btnNovoHardware_Click(object sender, EventArgs e)
        {
            frm_RegistroDisp registroDisp = new frm_RegistroDisp(tenantId); // Passa o tenant_id para o formulário de registro
            registroDisp.Show();
        }

        private void btnEditarRegistroHardware_Click(object sender, EventArgs e)
        {
            if (selectedHardware != null)
            {
                DataRow hardwareData = selectedHardware;
                frm_Editar_Dispositivos editarDisp = new frm_Editar_Dispositivos(hardwareData, tenantId);
                editarDisp.Show();
            }
            else
            {
                MessageBox.Show("Selecione um hardware para editar.");
            }
        }

        private void btnAtualizarHardware_Click(object sender, EventArgs e)
        {
            LoadHardwareData();
        }

        private void btnExcluirHardware_Click(object sender, EventArgs e)
        {
            if (selectedHardware != null)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este hardware?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        string deleteQuery = "DELETE FROM hardware WHERE tag = @tag AND tenant_id = @tenantId";
                        MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                        cmd.Parameters.AddWithValue("@tag", selectedHardware["tag"].ToString());
                        cmd.Parameters.AddWithValue("@tenantId", tenantId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Hardware excluído com sucesso!");
                            LoadHardwareData();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum hardware foi excluído.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir hardware: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um hardware para excluir.");
            }
        }
    }
}