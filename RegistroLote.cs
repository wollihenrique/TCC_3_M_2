using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCC_3_M
{
    public partial class frm_RegistroLote : Form
    {
        private string connectionString = "server=localhost;database=inventory_system;uid=root;pwd=etec;";
        private int tenantId;

        public frm_RegistroLote(int tenantId)
        {
            InitializeComponent();
            this.tenantId = tenantId;
            CarregarFornecedores();
        }

        private void LimparCampos()
        {
            txtLoteF.Text = "";
            txtDataRecebimentoLote.Text = "";
            cmbFornecedorLote.SelectedIndex = -1;
        }

        private void CarregarFornecedores()
        {
            cmbFornecedorLote.Items.Clear();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT name FROM supplier WHERE tenant_id = @TenantId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenantId", tenantId);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbFornecedorLote.Items.Add(reader["name"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarData(string data)
        {
            return Regex.IsMatch(data, @"^(0?[1-9]|[12][0-9]|3[01])[/](0?[1-9]|1[012])[/]\d{4}$");
        }

        private void btnLimparCadLote_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvarCadLote_Click(object sender, EventArgs e)
        {
            string nomeLote = txtLoteF.Text;
            string dataRecebimento = txtDataRecebimentoLote.Text;
            string fornecedor = cmbFornecedorLote.Text;

            if (string.IsNullOrEmpty(nomeLote) || string.IsNullOrEmpty(dataRecebimento) || string.IsNullOrEmpty(fornecedor))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarData(dataRecebimento))
            {
                MessageBox.Show("Data de recebimento inválida. Use o formato: dd/mm/aaaa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO batch (id, supplier_id, entering_date, tenant_id) VALUES (@id, @supplier_id, @entering_date, @tenantId)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", nomeLote);
                        command.Parameters.AddWithValue("@supplier_id", cmbFornecedorLote.SelectedIndex + 1);
                        command.Parameters.AddWithValue("@entering_date", Convert.ToDateTime(dataRecebimento));
                        command.Parameters.AddWithValue("@tenantId", tenantId);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Lote cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar lote: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCloseFrmCadastroLote_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}