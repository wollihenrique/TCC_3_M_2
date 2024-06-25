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
    public partial class frm_RegistroPeriferico : Form
    {
        private string connectionString = "server=localhost;database=inventory_system;user=root;password=etec;";
        private int tenantId;

        public frm_RegistroPeriferico(int tenantId)
        {
            InitializeComponent();
            this.tenantId = tenantId; // Atribui o tenantId recebido ao campo privado
            PopulateTipoComboBox();
            PopulateStatusComboBox();
            PopulateLoteComboBox();
        }

        private void btnCloseFrmRegistroPerifericos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarFrmCadastroP_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipoFrmCadastroP.SelectedItem?.ToString();
            string modelo = txtModeloCadastroP.Text.Trim();
            string status = cmbStatusFrmCadastroP.SelectedItem?.ToString();
            string loteId = cmbLoteFrmCadastroP.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(loteId))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO peripherals (batch_id, type, model, status, tenant_id)
                                     VALUES (@BatchId, @Type, @Model, @Status, @TenantId)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BatchId", loteId);
                    cmd.Parameters.AddWithValue("@Type", tipo);
                    cmd.Parameters.AddWithValue("@Model", modelo);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@TenantId", tenantId); // Adiciona o tenantId como parâmetro

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Periférico registrado com sucesso!");
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao registrar periférico.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar periférico: " + ex.Message);
                }
            }
        }

        private void btnCancelarFrmCadastroP_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            cmbTipoFrmCadastroP.SelectedIndex = -1;
            txtModeloCadastroP.Clear();
            cmbStatusFrmCadastroP.SelectedIndex = -1;
            cmbLoteFrmCadastroP.SelectedIndex = -1;
        }

        private void PopulateTipoComboBox()
        {
            cmbTipoFrmCadastroP.Items.Clear();
            string[] tipos = { "Monitor", "Teclado", "Mouse", "Impressora", "Scanner", "Webcam", "Headset", "Caixa de som", "Pendrive", "HD Externo", "Microfone" };

            cmbTipoFrmCadastroP.Items.AddRange(tipos);
            cmbTipoFrmCadastroP.SelectedIndex = -1;
        }

        private void PopulateStatusComboBox()
        {
            cmbStatusFrmCadastroP.Items.AddRange(new string[] { "Em Uso", "Estoque", "Defeituoso", "Manutenção" });
            cmbStatusFrmCadastroP.SelectedIndex = -1;
        }

        private void PopulateLoteComboBox()
        {
            cmbLoteFrmCadastroP.Items.Clear();
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
                        cmbLoteFrmCadastroP.Items.Add(reader["id"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar lotes: " + ex.Message);
                }
            }
        }
    }
}