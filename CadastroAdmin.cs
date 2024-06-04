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
                string.IsNullOrWhiteSpace(txtSenhaCadastro.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(txtCpfCadastro.Text, @"^\d{11}$"))
            {
                MessageBox.Show("CPF inválido. Deve conter apenas números e ter 11 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Encriptar a senha antes de inserir no banco de dados
                    string hashedPassword = HashPassword(txtSenhaCadastro.Text);

                    string sql = "INSERT INTO admin (`name`, `password`, cpf, email, phone) VALUES (@name, @password, @cpf, @email, @phone)";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
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
    }
}