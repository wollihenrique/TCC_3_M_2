using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TCC_3_M
{
    public partial class Contatos : Form
    {
        private string connectionString = "Server=localhost;Database=inventory_system;Uid=root;Pwd=etec;";

        public Contatos()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeContatos.Text.Trim();
            string telefone = txtTelefoneContatos.Text.Trim();
            string email = txtEmailContatos.Text.Trim();
            string mensagem = rtxtContatos.Text.Trim();
            DateTime dataEnvio = DateTime.Now;

            // Validar campos
            if (!ValidarNome(nome))
            {
                MessageBox.Show("Por favor, preencha o nome corretamente (apenas letras e espaços).");
                return;
            }

            if (!ValidarTelefone(telefone))
            {
                MessageBox.Show("Formato inválido para o telefone. Por favor, use apenas números e '-' se necessário, e não exceda 11 dígitos.");
                return;
            }

            if (!ValidarEmail(email))
            {
                MessageBox.Show("Formato inválido para o email. Por favor, verifique e tente novamente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(mensagem))
            {
                MessageBox.Show("Por favor, preencha a mensagem.");
                return;
            }

            // Inserir na base de dados
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO contact (`name`, `phone`, `email`, message, send_date) 
                                     VALUES (@Name, @Phone, @Email, @Message, @SendDate)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", nome);
                        command.Parameters.AddWithValue("@Phone", telefone);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Message", mensagem);
                        command.Parameters.AddWithValue("@SendDate", dataEnvio);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mensagem enviada com sucesso!");
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao enviar mensagem. Tente novamente.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar mensagem: {ex.Message}");
            }
        }

        private bool ValidarNome(string nome)
        {
            // Validar se o nome contém apenas letras e espaços
            return Regex.IsMatch(nome, @"^[a-zA-Z\s]+$");
        }

        private bool ValidarTelefone(string telefone)
        {
            // Verificar se o telefone contém apenas números e não excede 11 dígitos
            return Regex.IsMatch(telefone, @"^\d{1,11}$");
        }

        private bool ValidarEmail(string email)
        {
            // Verificar formato válido de email
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        private void LimparCampos()
        {
            txtNomeContatos.Clear();
            txtTelefoneContatos.Clear();
            txtEmailContatos.Clear();
            rtxtContatos.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
