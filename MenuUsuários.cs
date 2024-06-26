using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCC_3_M
{
    public partial class frm_Usuario : Form
    {
        private string connectionString = "Server=localhost;Database=inventory_system;Uid=root;Pwd=etec";
        private int tenantId;
        private string emailLogado;

        public frm_Usuario(string email)
        {
            InitializeComponent();
            this.Load += frm_Usuario_Load;
            emailLogado = email;
            tenantId = ObterTenantId(emailLogado);

            // Adicione os eventos TextChanged
            txtCpfUsuario.TextChanged += txtCpfUsuario_TextChanged;
            txtNomeUsuario.TextChanged += txtNomeUsuario_TextChanged;
        }

        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            CarregarDadosUsuarios();
        }

        private void CarregarDadosUsuarios()
        {
            string nomeUsuario = txtNomeUsuario.Text.Trim();
            string cpfUsuario = txtCpfUsuario.Text.Trim();

            string query = @"
        SELECT id, `name`, cpf, phone, email, 'User' as user_type 
        FROM `user` 
        WHERE tenant_id = @tenantId 
          AND (
               (`name` LIKE @nomeUsuario OR @nomeUsuario IS NULL)
               AND (cpf LIKE @cpfUsuario OR @cpfUsuario IS NULL)
              )
        UNION
        SELECT id, `name`, cpf, phone, email, 'Admin' as user_type 
        FROM `admin` 
        WHERE tenant_id = @tenantId 
          AND (
               (`name` LIKE @nomeUsuario OR @nomeUsuario IS NULL)
               AND (cpf LIKE @cpfUsuario OR @cpfUsuario IS NULL)
              )
    ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@tenantId", tenantId);
                    command.Parameters.AddWithValue("@nomeUsuario", string.IsNullOrWhiteSpace(nomeUsuario) ? (object)DBNull.Value : $"%{nomeUsuario}%");
                    command.Parameters.AddWithValue("@cpfUsuario", string.IsNullOrWhiteSpace(cpfUsuario) ? (object)DBNull.Value : $"%{cpfUsuario}%");

                    connection.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvUsuarios.DataSource = table;

                        // Configurar as colunas do DataGridView
                        dgvUsuarios.Columns["id"].Visible = false;
                        dgvUsuarios.Columns["name"].HeaderText = "Nome";
                        dgvUsuarios.Columns["cpf"].HeaderText = "CPF";
                        dgvUsuarios.Columns["phone"].HeaderText = "Telefone";
                        dgvUsuarios.Columns["email"].HeaderText = "Email";
                        dgvUsuarios.Columns["user_type"].HeaderText = "Tipo de Usuário";

                        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }


        private int ObterTenantId(string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlAdmin = "SELECT tenant_id FROM admin WHERE email = @usuario";
                    using (MySqlCommand cmdAdmin = new MySqlCommand(sqlAdmin, connection))
                    {
                        cmdAdmin.Parameters.AddWithValue("@usuario", email);

                        object resultAdmin = cmdAdmin.ExecuteScalar();

                        if (resultAdmin != null && resultAdmin != DBNull.Value)
                        {
                            return Convert.ToInt32(resultAdmin);
                        }
                    }

                    string sqlUser = "SELECT tenant_id FROM user WHERE email = @usuario";
                    using (MySqlCommand cmdUser = new MySqlCommand(sqlUser, connection))
                    {
                        cmdUser.Parameters.AddWithValue("@usuario", email);

                        object resultUser = cmdUser.ExecuteScalar();

                        if (resultUser != null && resultUser != DBNull.Value)
                        {
                            return Convert.ToInt32(resultUser);
                        }
                    }

                    MessageBox.Show("Não foi possível encontrar o tenant_id para o administrador logado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter tenant_id: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frm_RegistroUsuario formRegistroUsuario = new frm_RegistroUsuario(tenantId);
            formRegistroUsuario.ShowDialog();
            CarregarDadosUsuarios();
        }

        private void btnEditarRegistroUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["id"].Value);

                frm_EditarUsuario formEditarUsuario = new frm_EditarUsuario(idUsuario);
                formEditarUsuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um usuário para editar.");
            }
        }

        private void btnAtualizarUsuario_Click(object sender, EventArgs e)
        {
            CarregarDadosUsuarios();
        }

        private void btnCloseMenuUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["id"].Value);
                string userType = dgvUsuarios.SelectedRows[0].Cells["user_type"].Value.ToString();

                if (MessageBox.Show($"Tem certeza que deseja excluir este {userType}?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExcluirUsuario(idUsuario, userType);
                    CarregarDadosUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para excluir.");
            }
        }

        private void ExcluirUsuario(int idUsuario, string userType)
        {
            string tabela = userType == "User" ? "user" : "admin";
            string query = $"DELETE FROM {tabela} WHERE id = @Id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@Id", idUsuario);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{userType} excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show($"Não foi possível excluir o {userType}.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir usuário: " + ex.Message);
                }
            }
        }

        private void txtCpfUsuario_TextChanged(object sender, EventArgs e)
        {
            CarregarDadosUsuarios();
        }

        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {
            CarregarDadosUsuarios();
        }
    }
}