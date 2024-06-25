using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCC_3_M
{
    public partial class frm_Menu_Perifericos : Form
    {
        private string connectionString = "server=localhost;database=inventory_system;user=root;password=etec;";
        private int tenantId;

        public frm_Menu_Perifericos(string emailDoAdministradorLogado, int tenantId)
        {
            InitializeComponent();
            this.tenantId = tenantId;

            DesvincularEventos();
            VincularEventos();

            LoadPeripheralsData();
            PopulateStatusComboBox();
            PopulateOrderByComboBox();
            PopulateTipoPerifericosComboBox();
        }

        private void VincularEventos()
        {
            cmbStatusPerifericos.SelectedIndexChanged += cmbStatusPerifericos_SelectedIndexChanged;
            cmbOrderByPerifericos.SelectedIndexChanged += cmbOrderByPerifericos_SelectedIndexChanged;
            cmbTipoPerifericos.SelectedIndexChanged += cmbTipoPerifericos_SelectedIndexChanged;
            txtModeloPerifericos.TextChanged += txtModeloPerifericos_TextChanged;
            btnExcluirPeriferico.Click += btnExcluirPeriferico_Click;
            btnAtualizarPeriferico.Click += btnAtualizarPeriferico_Click;
            btnEditarRegistroPerifericos.Click += btnEditarRegistroPerifericos_Click;
            btnNovoPeriferico.Click += btnNovoPeriferico_Click;
            btnCloseMenuPerifericos.Click += btnCloseMenuPerifericos_Click;
        }

        private void DesvincularEventos()
        {
            cmbStatusPerifericos.SelectedIndexChanged -= cmbStatusPerifericos_SelectedIndexChanged;
            cmbOrderByPerifericos.SelectedIndexChanged -= cmbOrderByPerifericos_SelectedIndexChanged;
            cmbTipoPerifericos.SelectedIndexChanged -= cmbTipoPerifericos_SelectedIndexChanged;
            txtModeloPerifericos.TextChanged -= txtModeloPerifericos_TextChanged;
            btnExcluirPeriferico.Click -= btnExcluirPeriferico_Click;
            btnAtualizarPeriferico.Click -= btnAtualizarPeriferico_Click;
            btnEditarRegistroPerifericos.Click -= btnEditarRegistroPerifericos_Click;
            btnNovoPeriferico.Click -= btnNovoPeriferico_Click;
            btnCloseMenuPerifericos.Click -= btnCloseMenuPerifericos_Click;
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
            cmbStatusPerifericos.SelectedIndex = -1;
        }

        private void PopulateOrderByComboBox()
        {
            cmbOrderByPerifericos.Items.AddRange(new string[] { "Mais recentes", "Mais antigos", "Este mês", "Este ano" });
            cmbOrderByPerifericos.SelectedIndex = -1;
        }

        private void PopulateTipoPerifericosComboBox()
        {
            cmbTipoPerifericos.Items.Clear();
            string[] tipos = { "Monitor", "Teclado", "Mouse", "Impressora", "Scanner", "Webcam", "Headset", "Caixa de som", "Pendrive", "HD Externo", "Microfone" };

            cmbTipoPerifericos.Items.AddRange(tipos);
            cmbTipoPerifericos.SelectedIndex = -1;
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

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.id, p.batch_id, p.type, p.model, p.status, b.entering_date 
                                     FROM peripherals p
                                     JOIN batch b ON p.batch_id = b.id
                                     WHERE p.type = @Tipo
                                     AND b.tenant_id = @TenantId";

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

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.id, p.batch_id, p.type, p.model, p.status, b.entering_date 
                                     FROM peripherals p
                                     JOIN batch b ON p.batch_id = b.id
                                     WHERE p.model LIKE @Modelo
                                     AND b.tenant_id = @TenantId";

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
            formNovoPeriferico.ShowDialog();
            LoadPeripheralsData();
        }

        private void btnEditarRegistroPerifericos_Click(object sender, EventArgs e)
        {
            if (dgvPerifericos.SelectedRows.Count > 0)
            {
                int perifericoId = Convert.ToInt32(dgvPerifericos.SelectedRows[0].Cells["id"].Value);

                frm_EditarPerifericos editarPerifericoForm = new frm_EditarPerifericos(perifericoId, tenantId);
                editarPerifericoForm.ShowDialog();
                LoadPeripheralsData();
            }
            else
            {
                MessageBox.Show("Selecione um periférico para editar.");
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
            if (dgvPerifericos.SelectedRows.Count > 0)
            {
                int idPeriferico = Convert.ToInt32(dgvPerifericos.SelectedRows[0].Cells["id"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este periférico?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ExcluirPeriferico(idPeriferico);
                    LoadPeripheralsData();
                }
            }
            else
            {
                MessageBox.Show("Selecione um periférico para excluir.");
            }
        }

        private void ExcluirPeriferico(int idPeriferico)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM peripherals WHERE id = @PerifericoId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PerifericoId", idPeriferico); // Adiciona o valor do parâmetro

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Periférico excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir periférico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir periférico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
