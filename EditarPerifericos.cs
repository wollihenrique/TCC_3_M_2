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
    public partial class frm_EditarPerifericos : Form
    {
        private string connectionString = "server=localhost;database=inventory_system;user=root;password=etec;"; // Sua string de conexão MySQL
        private int idPeriferico;
        private int batchId;

        public frm_EditarPerifericos(int idPeriferico, string tipoPeriferico, string modeloPeriferico, string statusPeriferico, int batchId)
        {
            InitializeComponent();

            this.idPeriferico = idPeriferico;
            this.batchId = batchId;

            txtModeloFrmEditarP.Text = modeloPeriferico;

            // Preenchendo a ComboBox de Tipo de Periférico com as opções da tela de registro
            string[] tiposPerifericos = { "Monitor", "Teclado", "Mouse", "Impressora", "Scanner", "Webcam", "Headset", "Caixa de som", "Pendrive", "HD Externo", "Microfone" };
            cmbTipoPerifericoFrmEditarP.Items.AddRange(tiposPerifericos);
            cmbTipoPerifericoFrmEditarP.SelectedItem = tipoPeriferico;

            // Preenchendo a ComboBox de Status com as opções da tela de registro
            string[] statusPerifericos = { "Em Uso", "Estoque", "Defeituoso", "Manutenção" };
            cmbStatusFrmEditarP.Items.AddRange(statusPerifericos);
            cmbStatusFrmEditarP.SelectedItem = statusPeriferico;
        }

        private void btnCloseFrmEditarPerifericos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarFrmEditarP_Click(object sender, EventArgs e)
        {
            // Obtém os novos valores dos campos
            string modelo = txtModeloFrmEditarP.Text.Trim();
            string tipo = cmbTipoPerifericoFrmEditarP.SelectedItem.ToString();
            string status = cmbStatusFrmEditarP.SelectedItem.ToString();

            // Atualiza os dados no banco de dados MySQL
            AtualizarPeriferico(idPeriferico, tipo, modelo, status);

            MessageBox.Show("Periférico editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Fecha o formulário após salvar
        }

        private void btnCancelarFrmEditarP_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário sem salvar as alterações
        }

        private void AtualizarPeriferico(int id, string tipo, string modelo, string status)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE peripherals 
                                     SET type = @Tipo, model = @Modelo, status = @Status 
                                     WHERE id = @Id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Periférico atualizado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Falha ao atualizar periférico.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar atualizar o periférico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
