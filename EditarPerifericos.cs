using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCC_3_M
{
    public partial class frm_EditarPerifericos : Form
    {
        private string connectionString = "server=localhost;database=inventory_system;user=root;password=etec;";
        private int perifericoId;
        private int tenantId;

        public frm_EditarPerifericos(int idPeriferico, int tenantId)
        {
            InitializeComponent();
            perifericoId = idPeriferico;
            this.tenantId = tenantId;

            PopulateComboBoxes();
            LoadPerifericoData();
        }

        private void PopulateComboBoxes()
        {
            PopulateTipoPerifericosComboBox();
            PopulateStatusComboBox();
            PopulateLoteComboBox();
        }

        private void PopulateTipoPerifericosComboBox()
        {
            cmbTipoPerifericoFrmEditarP.Items.AddRange(new object[] { "Teclado", "Mouse", "Scanner", "Microfone", "Impressora", "Caixa de Som", "Fones de Ouvido", "WebCam" });
        }

        private void PopulateStatusComboBox()
        {
            cmbStatusFrmEditarP.Items.AddRange(new object[] { "Em Uso", "Estoque", "Defeituoso", "Manutenção" });
        }

        private void PopulateLoteComboBox()
        {
            cmbLoteFrmEditarP.Items.Clear(); // Limpar itens anteriores

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id FROM batch WHERE tenant_id = @TenantId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenantId", tenantId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string id = reader.GetString(0); // Lê como string, já que o batch_id é VARCHAR
                        cmbLoteFrmEditarP.Items.Add(id); // Adiciona apenas o ID do lote à ComboBox
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar lotes: " + ex.Message);
                }
            }
        }

        private void LoadPerifericoData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.model, p.type, p.status, p.batch_id
                             FROM peripherals p
                             WHERE p.id = @PerifericoId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PerifericoId", perifericoId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtModeloFrmEditarP.Text = reader.GetString(0);
                        cmbTipoPerifericoFrmEditarP.SelectedItem = reader.GetString(1);
                        cmbStatusFrmEditarP.SelectedItem = reader.GetString(2);

                        string loteId = reader.GetString(3); // Lê como string, já que o batch_id é VARCHAR
                        cmbLoteFrmEditarP.SelectedItem = loteId;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados do periférico: " + ex.Message);
                }
            }
        }

        private void btnCloseFrmEditarPerifericos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarFrmEditarP_Click(object sender, EventArgs e)
        {
            string modelo = txtModeloFrmEditarP.Text.Trim();
            string tipo = cmbTipoPerifericoFrmEditarP.SelectedItem?.ToString();
            string status = cmbStatusFrmEditarP.SelectedItem?.ToString();
            string loteId = cmbLoteFrmEditarP.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(loteId))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE peripherals
                                     SET model = @Modelo, type = @Tipo, status = @Status, batch_id = @LoteId
                                     WHERE id = @PerifericoId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@LoteId", loteId); // Passa loteId como string diretamente
                    cmd.Parameters.AddWithValue("@PerifericoId", perifericoId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dados do periférico atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar dados do periférico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar dados do periférico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}