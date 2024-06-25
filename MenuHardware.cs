using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCC_3_M
{
    public partial class frm_CadastroDisp : Form
    {
        private MySqlConnection connection;
        private DataTable dataTable;
        private DataRow selectedHardware;
        private DataGridView dgvHardware;
        private int tenantId; // Variável para armazenar o tenant_id

        public frm_CadastroDisp(string emailDoAdministradorLogado, int tenantId)
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            this.tenantId = tenantId; // Atribui o tenant_id recebido do formulário pai
            LoadHardwareData();
            SetupComboBoxes();
            txtTag.TextChanged += new EventHandler(txtTag_TextChanged);
            dgvHardware.SelectionChanged += new EventHandler(dgvHardware_SelectionChanged);
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "server=localhost;database=inventory_system;user=root;password=etec";
            connection = new MySqlConnection(connectionString);
        }

        private void LoadHardwareData(string orderBy = "", string statusFilter = "")
        {
            try
            {
                connection.Open();
                string query = @"
                    SELECT h.tag, h.assurance, h.model, h.brand, h.status, h.processor, h.ram, h.disk, h.video_card, h.network_card, h.observations, h.batch_id, b.entering_date 
                    FROM hardware h
                    JOIN batch b ON h.batch_id = b.id
                    WHERE h.tenant_id = @tenantId"; // Adicionado filtro por tenant_id

                if (!string.IsNullOrEmpty(statusFilter))
                {
                    query += " AND h.status = @status";
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
                cmd.Parameters.AddWithValue("@tenantId", tenantId); // Passa o tenant_id como parâmetro

                if (!string.IsNullOrEmpty(statusFilter))
                {
                    cmd.Parameters.AddWithValue("@status", statusFilter);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Adiciona uma nova coluna para o lote
                DataColumn column = new DataColumn("Lote", typeof(string));
                dataTable.Columns.Add(column);

                // Preenche a coluna do lote com os dados
                foreach (DataRow row in dataTable.Rows)
                {
                    row["Lote"] = row["batch_id"].ToString();
                }

                dgvHardware.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void SetupComboBoxes()
        {
            cmbOrderBy.Items.Add("Mais recentes");
            cmbOrderBy.Items.Add("Mais antigos");
            cmbOrderBy.Items.Add("Este mês");
            cmbOrderBy.Items.Add("Este ano");
            cmbOrderBy.SelectedIndexChanged += new EventHandler(cmbOrderBy_SelectedIndexChanged);

            cmbStatus.Items.Add("Em Uso");
            cmbStatus.Items.Add("Estoque");
            cmbStatus.Items.Add("Manutenção");
            cmbStatus.Items.Add("Defeituoso");
            cmbStatus.SelectedIndexChanged += new EventHandler(cmbStatus_SelectedIndexChanged);
        }

        private void cmbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOrder = cmbOrderBy.SelectedItem.ToString();
            string selectedStatus = cmbStatus.SelectedItem?.ToString() ?? "";
            LoadHardwareData(selectedOrder, selectedStatus);
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cmbStatus.SelectedItem.ToString();
            string selectedOrder = cmbOrderBy.SelectedItem?.ToString() ?? "";
            LoadHardwareData(selectedOrder, selectedStatus);
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

        private void btn_Pesquisar_CadastroDispo_Click(object sender, EventArgs e)
        {
            string tagFilter = txtTag.Text.Trim();
            DataView dv = new DataView(dataTable);
            dv.RowFilter = $"tag = '{tagFilter}'";
            dgvHardware.DataSource = dv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void btnNovoLote_Click(object sender, EventArgs e)
        {
            frm_RegistroLote registroLote = new frm_RegistroLote(tenantId);
            registroLote.Show();
        }

        private void btnAtualizarHardware_Click_1(object sender, EventArgs e)
        {
            LoadHardwareData();
        }

        private void btnExcluirHardware_Click(object sender, EventArgs e)
        {
            if (selectedHardware != null)
            {
                DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir este hardware?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM hardware WHERE tag = @Tag AND tenant_id = @tenantId"; // Adicionado filtro por tenant_id
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Tag", selectedHardware["tag"]);
                        cmd.Parameters.AddWithValue("@tenantId", tenantId); // Passa o tenant_id como parâmetro
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Hardware excluído com sucesso.");
                        LoadHardwareData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir hardware: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
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