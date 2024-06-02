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
using System.Security.Cryptography;

namespace TCC_3_M
{
    public partial class frm_Login : Form
    {
        private string connectionString = "server=localhost;database=inventory_system;uid=root;password=vini";

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Log_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioLogin.Text;
            string senha = txtSenhaLogin.Text;

            if (VerificarLogin(usuario, senha))
            {
                frm_Inicio frm_Inicio = new frm_Inicio();
                frm_Inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarLogin(string usuario, string senha)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT password FROM (SELECT id, name, password, 'admin' AS role FROM admin UNION SELECT id, name, password, 'user' AS role FROM user) AS combined_users WHERE name = @usuario";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string storedHash = result.ToString();
                        return PasswordHelper.VerifyPassword(senha, storedHash);
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao verificar o login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void lnkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_CadastroAdmin formCadastroAdmin = new frm_CadastroAdmin();
            formCadastroAdmin.Show();
            this.Hide();
        }

        private void txtSenhaLogin_TextChanged(object sender, EventArgs e)
        {
            txtSenhaLogin.PasswordChar = '*';
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
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

        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string hashOfEnteredPassword = HashPassword(enteredPassword);
            return string.Equals(hashOfEnteredPassword, storedHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}
