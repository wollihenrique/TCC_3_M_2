using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCC_3_M
{
    public partial class frm_RegistroUsuario : Form
    {
        private string connectionString = "Server=localhost;Database=inventory_system;Uid=root;Pwd=etec";
        private int tenantId;

        public frm_RegistroUsuario()
        {
            InitializeComponent();
        }

        public frm_RegistroUsuario(int tenantId)
        {
            InitializeComponent();
            this.tenantId = tenantId; // Recebe o tenant_id passado como parâmetro
        }

        private bool IsValidCPF(string cpf)
        {
            cpf = Regex.Replace(cpf, "[^0-9]", "");

            if (!Regex.IsMatch(cpf, @"^\d{11}$"))
                return false;

            if (cpf == "00000000000" || cpf == "11111111111" || cpf == "22222222222" ||
                cpf == "33333333333" || cpf == "44444444444" || cpf == "55555555555" ||
                cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" ||
                cpf == "99999999999")
                return false;

            if (cpf.Length != 11 || !Regex.IsMatch(cpf, @"^\d{11}$"))
            {
                return false;
            }

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
                    string query = "SELECT COUNT(*) FROM (SELECT email FROM user UNION ALL SELECT email FROM admin) AS combined WHERE email = @Email";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 0; // Se count == 0, o e-mail é único
                }
                catch
                {
                    return false;
                }
            }
        }

        private bool IsCPFUnique(string cpf)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM (SELECT cpf FROM user UNION ALL SELECT cpf FROM admin) AS combined WHERE cpf = @CPF";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CPF", cpf);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 0; // Se count == 0, o CPF é único
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
                    string query = "SELECT COUNT(*) FROM (SELECT phone FROM user UNION ALL SELECT phone FROM admin) AS combined WHERE phone = @Phone";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Phone", phone);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 0; // Se count == 0, o número de telefone é único
                }
                catch
                {
                    return false;
                }
            }
        }

        private void btnSalvarFrmCadastroU_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCompletoCadU.Text;
            string email = txtEmailCadU.Text;
            string cpf = Regex.Replace(masktxtCpfCadU.Text, "[^0-9]", "");
            string telefone = Regex.Replace(masktxtTelefoneCadU.Text, "[^0-9]", "");
            string senha = txtSenhaCadU.Text;
            string confirmSenha = txtConfirmSenhaCadU.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(confirmSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (!IsValidCPF(cpf))
            {
                MessageBox.Show("CPF inválido.");
                return;
            }

            if (!IsEmailUnique(email))
            {
                MessageBox.Show("Este email já está cadastrado.");
                return;
            }

            if (!IsCPFUnique(cpf))
            {
                MessageBox.Show("Este CPF já está cadastrado.");
                return;
            }

            if (!IsPhoneUnique(telefone))
            {
                MessageBox.Show("Este número de telefone já está cadastrado.");
                return;
            }

            if (senha != confirmSenha)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO user (tenant_id, name, password, email, cpf, phone) VALUES (@TenantId, @Name, @Password, @Email, @CPF, @Phone)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenantId", tenantId); // Adiciona o tenant_id ao parâmetro
                    command.Parameters.AddWithValue("@Name", nome);
                    command.Parameters.AddWithValue("@Password", HashPassword(senha));
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@CPF", cpf);
                    command.Parameters.AddWithValue("@Phone", telefone);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuário registrado com sucesso!");
                    this.Close(); // Fecha o formulário após o registro
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar usuário: " + ex.Message);
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnLimparFrmCadastroU_Click(object sender, EventArgs e)
        {
            txtNomeCompletoCadU.Text = "";
            txtEmailCadU.Text = "";
            masktxtCpfCadU.Text = "";
            masktxtTelefoneCadU.Text = "";
            txtSenhaCadU.Text = "";
            txtConfirmSenhaCadU.Text = "";
        }

        private void btnCloseFrmCadsatroU_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}