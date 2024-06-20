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
    public partial class frm_MenuPerifericos : Form
    {
        private string connectionString = "server=localhost;database=inventory_system;user=root;password=etec;";
        private int tenantId;

        public frm_MenuPerifericos(string emailDoAdministradorLogado, int tenantId)
        {
            InitializeComponent();
            this.tenantId = tenantId; // Atribui o tenantId recebido ao campo privado

            LoadPeripheralsData();
            PopulateStatusComboBox();
            PopulateOrderByComboBox();
            PopulateTipoPerifericosComboBox();
            cmbStatusPerifericos.SelectedIndexChanged += cmbStatusPerifericos_SelectedIndexChanged;
            cmbOrderByPerifericos.SelectedIndexChanged += cmbOrderByPerifericos_SelectedIndexChanged;
            cmbTipoPerifericos.SelectedIndexChanged += cmbTipoPerifericos_SelectedIndexChanged;
            txtModeloPerifericos.TextChanged += txtModeloPerifericos_TextChanged;
            btnExcluirPeriferico.Click += btnExcluirPeriferico_Click;
            btnAtualizarPeriferico.Click += btnAtualizarPeriferico_Click;
        }

        private void LoadPeripheralsData(string statusFilter = "", string orderBy = "")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.id, p.batch_id, p.type, p.model, p.status, b.entering_date 
                                     FROM peripherals p
                                     JOIN batch b ON p.batch_id = b.id
                                     WHERE b.tenant_id = @TenantId"; // Filtra pelo tenantId

                    if (!string.IsNullOrEmpty(statusFilter))
                    {
                        query += $" AND p.status = '{statusFilter}'";
                    }

                    if (!string.IsNullOrEmpty(orderBy))
                    {
                        switch (orderBy)
                        {
                            case "Mais recentes":
                                query += " ORDER BY b.entering_date DESC";
                                break;
                            case "Mais antigos":
                                query += " ORDER BY b.entering_date ASC";
                                break;
                            case "Este mês":
                                query += " AND MONTH(b.entering_date) = MONTH(NOW())";
                                break;
                            case "Este ano":
                                query += " AND YEAR(b.entering_date) = YEAR(NOW())";
                                break;
                        }
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenantId", tenantId);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPerifericos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void PopulateStatusComboBox()
        {
            cmbStatusPerifericos.Items.AddRange(new string[] { "Em Uso", "Estoque", "Defeituoso", "Manutenção" });
            cmbStatusPerifericos.SelectedIndex = -1; // Deixe sem seleção inicial
        }

        private void PopulateOrderByComboBox()
        {
            cmbOrderByPerifericos.Items.AddRange(new string[] { "Mais recentes", "Mais antigos", "Este mês", "Este ano" });
            cmbOrderByPerifericos.SelectedIndex = -1; // Deixe sem seleção inicial
        }

        private void PopulateTipoPerifericosComboBox()
        {
            cmbTipoPerifericos.Items.Clear(); // Limpar itens anteriores
            string[] tipos = { "Monitor", "Teclado", "Mouse", "Impressora", "Scanner", "Webcam", "Headset", "Caixa de som", "Pendrive", "HD Externo", "Microfone" };

            cmbTipoPerifericos.Items.AddRange(tipos);
            cmbTipoPerifericos.SelectedIndex = -1; // Deixe sem seleção inicial
        }

        private void cmbStatusPerifericos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPeripheralsData(cmbStatusPerifericos.SelectedItem?.ToString(), cmbOrderByPerifericos.SelectedItem?.ToString());
        }

        private void cmbOrderByPerifericos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPeripheralsData(cmbStatusPerifericos.SelectedItem?.ToString(), cmbOrderByPerifericos.SelectedItem?.ToString());
        }

        private void cmbTipoPerifericos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSelecionado = cmbTipoPerifericos.SelectedItem.ToString();
            // Filtrar a lista de periféricos pelo tipo selecionado
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.id, p.batch_id, p.type, p.model, p.status, b.entering_date 
                                     FROM peripherals p
                                     JOIN batch b ON p.batch_id = b.id
                                     WHERE p.type = @Tipo
                                     AND b.tenant_id = @TenantId"; // Filtra pelo tenantId

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Tipo", tipoSelecionado);
                    cmd.Parameters.AddWithValue("@TenantId", tenantId);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPerifericos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtModeloPerifericos_TextChanged(object sender, EventArgs e)
        {
            string modeloDigitado = txtModeloPerifericos.Text.Trim();

            // Filtrar a lista de periféricos pelo modelo digitado
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.id, p.batch_id, p.type, p.model, p.status, b.entering_date 
                                     FROM peripherals p
                                     JOIN batch b ON p.batch_id = b.id
                                     WHERE p.model LIKE @Modelo
                                     AND b.tenant_id = @TenantId"; // Filtra pelo tenantId

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Modelo", "%" + modeloDigitado + "%");
                    cmd.Parameters.AddWithValue("@TenantId", tenantId);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPerifericos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnNovoPeriferico_Click(object sender, EventArgs e)
        {
            frm_RegistroPeriferico formNovoPeriferico = new frm_RegistroPeriferico(tenantId);
            formNovoPeriferico.Show();
        }

        private void btnEditarRegistroPerifericos_Click(object sender, EventArgs e)
        {
            if (dgvPerifericos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPerifericos.SelectedRows[0];
                int idPeriferico = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string tipoPeriferico = Convert.ToString(selectedRow.Cells["type"].Value);
                string modeloPeriferico = Convert.ToString(selectedRow.Cells["model"].Value);
                string statusPeriferico = Convert.ToString(selectedRow.Cells["status"].Value);
                int batchId = Convert.ToInt32(selectedRow.Cells["batch_id"].Value);
                frm_EditarPerifericos formEditarPerifericos = new frm_EditarPerifericos(idPeriferico, tipoPeriferico, modeloPeriferico, statusPeriferico, batchId);
                formEditarPerifericos.ShowDialog();
            }
        }

        private void btnCloseMenuPerifericos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizarPeriferico_Click(object sender, EventArgs e)
        {
            LoadPeripheralsData();
        }

        private void btnExcluirPeriferico_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada no DataGridView
            if (dgvPerifericos.SelectedRows.Count > 0)
            {
                // Obtém o ID do periférico da linha selecionada
                int idPeriferico = Convert.ToInt32(dgvPerifericos.SelectedRows[0].Cells["id"].Value);

                // Exibe um diálogo de confirmação para o usuário
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este periférico?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Se o usuário confirmar, realiza a exclusão no banco de dados
                    ExcluirPeriferico(idPeriferico);

                    // Atualiza o DataGridView após a exclusão
                    LoadPeripheralsData();
                }
            }
        }

        private void ExcluirPeriferico(int idPeriferico)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM peripherals WHERE id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", idPeriferico);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Periférico excluído com sucesso.", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir o periférico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar excluir o periférico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}