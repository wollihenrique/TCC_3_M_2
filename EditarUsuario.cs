using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCC_3_M
{
    public partial class frm_EditarUsuario : Form
    {
        private string connectionString = "Server=localhost;Database=inventory_system;Uid=root;Pwd=etec";
        private int idUsuario;

        public frm_EditarUsuario(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            CarregarDadosUsuario();
        }

        private void CarregarDadosUsuario()
        {
            string query = "SELECT `name`, cpf, phone, email FROM `user` WHERE id = @idUsuario";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtNomeCompletoU.Text = reader["name"].ToString();
                        masktxtCpfU.Text = reader["cpf"].ToString();
                        masktxtTelefoneU.Text = reader["phone"].ToString();
                        txtEmailU.Text = reader["email"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados do usuário: " + ex.Message);
                }
            }
        }

        private void btnCloseFrmCadastroU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarFrmU_Click(object sender, EventArgs e)
        {
            // Validar os campos antes de salvar
            if (ValidarCampos())
            {
                // Remover caracteres não numéricos do CPF e do telefone
                string cpf = RemoverNaoNumericos(masktxtCpfU.Text);
                string telefone = RemoverNaoNumericos(masktxtTelefoneU.Text);

                AtualizarUsuario(cpf, telefone);
            }
        }

        private bool ValidarCampos()
        {
            // Validar Nome Completo
            if (string.IsNullOrWhiteSpace(txtNomeCompletoU.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Nome Completo.");
                return false;
            }

            // Validar CPF
            if (string.IsNullOrWhiteSpace(masktxtCpfU.Text) || masktxtCpfU.Text.Length < 14 || !IsValidCPF(masktxtCpfU.Text))
            {
                MessageBox.Show("Por favor, preencha um CPF válido.");
                return false;
            }

            // Validar Telefone
            if (string.IsNullOrWhiteSpace(masktxtTelefoneU.Text) || masktxtTelefoneU.Text.Length < 14 || !IsPhoneUnique(masktxtTelefoneU.Text))
            {
                MessageBox.Show("Por favor, preencha um telefone válido e único.");
                return false;
            }

            // Validar E-mail
            if (string.IsNullOrWhiteSpace(txtEmailU.Text) || !IsValidEmail(txtEmailU.Text) || !IsEmailUnique(txtEmailU.Text))
            {
                MessageBox.Show("Por favor, preencha um e-mail válido e único.");
                return false;
            }

            return true;
        }

        private bool IsValidCPF(string cpf)
        {
            cpf = Regex.Replace(cpf, "[^0-9]", "");

            if (cpf.Length != 11 || !Regex.IsMatch(cpf, @"^\d{11}$"))
            {
                return false;
            }

            // Verificar se todos os dígitos são iguais
            if (new string(cpf[0], 11) == cpf)
            {
                return false;
            }

            int[] multiplier1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplier2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string partialCPF = cpf.Substring(0, 9);

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += int.Parse(partialCPF[i].ToString()) * multiplier1[i];
            }

            int remainder = sum % 11;
            if (remainder < 2)
            {
                remainder = 0;
            }
            else
            {
                remainder = 11 - remainder;
            }

            if (int.Parse(cpf[9].ToString()) != remainder)
            {
                return false;
            }

            sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * multiplier2[i];
            }

            remainder = sum % 11;
            if (remainder < 2)
            {
                remainder = 0;
            }
            else
            {
                remainder = 11 - remainder;
            }

            if (int.Parse(cpf[10].ToString()) != remainder)
            {
                return false;
            }

            return true;
        }

        private bool IsEmailUnique(string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM (SELECT email FROM user WHERE id <> @idUsuario UNION ALL SELECT email FROM admin) AS combined WHERE email = @Email";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 0; // Se count == 0, o e-mail é único (excluindo o próprio usuário)
                }
                catch
                {
                    return false;
                }
            }
        }

        private bool IsPhoneUnique(string phone)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM (SELECT phone FROM user WHERE id <> @idUsuario UNION ALL SELECT phone FROM admin) AS combined WHERE phone = @Phone";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 0; // Se count == 0, o número de telefone é único (excluindo o próprio usuário)
                }
                catch
                {
                    return false;
                }
            }
        }

        private void btnLimparFrmU_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNomeCompletoU.Text = "";
            masktxtCpfU.Text = "";
            masktxtTelefoneU.Text = "";
            txtEmailU.Text = "";
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void AtualizarUsuario(string cpf, string telefone)
        {
            string query = "UPDATE `user` SET `name` = @name, cpf = @cpf, phone = @phone, email = @email " +
                           "WHERE id = @idUsuario";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", txtNomeCompletoU.Text);
                    command.Parameters.AddWithValue("@cpf", cpf);
                    command.Parameters.AddWithValue("@phone", telefone);
                    command.Parameters.AddWithValue("@email", txtEmailU.Text);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dados do usuário atualizados com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar os dados do usuário.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar os dados do usuário: " + ex.Message);
                }
                finally
                {
                    this.Close();
                }
            }
        }

        private string RemoverNaoNumericos(string input)
        {
            // Remove todos os caracteres não numéricos
            return new string(input.Where(char.IsDigit).ToArray());
        }
    }
}