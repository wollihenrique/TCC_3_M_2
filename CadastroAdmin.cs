using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace TCC_3_M
{
    public partial class frm_CadastroAdmin : Form
    {
        string connectionString = "server=localhost;database=inventory_system;uid=root;password=etec";

        public frm_CadastroAdmin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Login formLogin = new frm_Login();
            formLogin.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtCpfCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtEmailCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtSenhaCadastro.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmSenha.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsCpfValid(txtCpfCadastro.Text))
            {
                MessageBox.Show("CPF inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(txtNumeroCadastro.Text, @"^\d{10,}$"))
            {
                MessageBox.Show("Número de telefone inválido. Deve conter apenas números e ter pelo menos 10 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(txtEmailCadastro.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("E-mail inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSenhaCadastro.Text.Length < 8)
            {
                MessageBox.Show("Senha deve conter pelo menos 8 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSenhaCadastro.Text != txtConfirmSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(txtNomeCadastro.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Nome de usuário inválido. Deve conter apenas letras e espaços.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!cnkTermosCondicoes.Checked)
            {
                MessageBox.Show("Você deve aceitar os termos e condições para se cadastrar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsDataAlreadyRegistered(txtCpfCadastro.Text, txtEmailCadastro.Text, txtNumeroCadastro.Text))
            {
                MessageBox.Show("O CPF, e-mail ou telefone já está cadastrado em outra conta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Geração automática do tenant_id
                    int tenantId = GenerateTenantId();

                    // Encriptar a senha antes de inserir no banco de dados
                    string hashedPassword = HashPassword(txtSenhaCadastro.Text);

                    string sql = "INSERT INTO admin (`tenant_id`, `name`, `password`, `cpf`, `email`, `phone`) VALUES (@tenantId, @name, @password, @cpf, @email, @phone)";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@tenantId", tenantId); // Inserindo tenant_id
                    cmd.Parameters.AddWithValue("@name", txtNomeCadastro.Text);
                    cmd.Parameters.AddWithValue("@password", hashedPassword); // Utilizando a senha encriptada
                    cmd.Parameters.AddWithValue("@cpf", txtCpfCadastro.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmailCadastro.Text);
                    cmd.Parameters.AddWithValue("@phone", txtNumeroCadastro.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();

                        // Redirecionar para a tela de login após o cadastro
                        frm_Login formLogin = new frm_Login();
                        formLogin.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao cadastrar. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsCpfValid(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        private bool IsDataAlreadyRegistered(string cpf, string email, string phone)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"
                SELECT COUNT(*) FROM (
                    SELECT cpf, email, phone FROM admin
                    UNION ALL
                    SELECT cpf, email, phone FROM user
                ) AS combined
                WHERE cpf = @cpf OR email = @mail OR phone = @phone";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@phone", phone);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private string HashPassword(string password)
        {
            string[] specialCharacters = { "'", "\"", "\\", "`", "*", "?", "[", "]", "{", "}", "(", ")", "<", ">", "|", ";", ",", "=", "&", "$", "#", "@" };

            foreach (var character in specialCharacters)
            {
                password = password.Replace(character, "\\" + character);
            }

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void LimparCampos()
        {
            txtNomeCadastro.Text = "";
            txtCpfCadastro.Text = "";
            txtNumeroCadastro.Text = "";
            txtEmailCadastro.Text = "";
            txtSenhaCadastro.Text = "";
            cnkTermosCondicoes.Checked = false;
        }

        private void lnkTermosCondicoes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_TermosDeUso termosDeUso = new frm_TermosDeUso();
            termosDeUso.Show();
        }

        private int GenerateTenantId()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }
    }
}