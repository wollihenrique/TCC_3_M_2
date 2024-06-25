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
        private string connectionString = "server=localhost;database=inventory_system;uid=root;password=etec";

        public frm_Login()
        {
            InitializeComponent();
        }

        // Método para obter o tenant_id do administrador ou do usuário
        public int ObterTenantId(string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sql = @"
                        SELECT tenant_id FROM (
                            SELECT tenant_id FROM admin WHERE email = @usuario
                            UNION
                            SELECT tenant_id FROM user WHERE email = @usuario
                        ) AS combined_users";

                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@usuario", email);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1; // Retorna -1 se o email não existir ou se o tenant_id não for encontrado
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter tenant_id: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
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

        private void btnEntrarLog_Click(object sender, EventArgs e)
        {
            string email = txtUsuarioLogin.Text;
            string senha = txtSenhaLogin.Text;

            int tenantId = ObterTenantId(email); // Obtém o tenantId usando o email

            if (VerificarLogin(email, senha, tenantId)) // Passa o tenantId para VerificarLogin
            {
                frm_Inicio menu = new frm_Inicio(); // Cria o formulário de início
                menu.DefinirEmailLogado(email, tenantId); // Passa o email e o tenant_id para frm_Inicio
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarLogin(string email, string senha, int tenantId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sql = @"
                        SELECT password
                        FROM (
                            SELECT email, password, tenant_id FROM admin
                            UNION
                            SELECT email, password, tenant_id FROM user
                        ) AS combined_users 
                        WHERE email = @usuario AND tenant_id = @tenantId";

                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@usuario", email);
                    cmd.Parameters.AddWithValue("@tenantId", tenantId);

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