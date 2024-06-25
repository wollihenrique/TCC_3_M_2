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
        private string emailLogado; // Adicione esta variável se ainda não existir

        public frm_Usuario(string email)
        {
            InitializeComponent();
            this.Load += frm_Usuario_Load;
            emailLogado = email; // Recebe o email do administrador logado
            tenantId = ObterTenantId(emailLogado);
        }

        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            CarregarDadosUsuarios();
        }

        private void CarregarDadosUsuarios()
        {
            string nomeUsuario = txtNomeUsuario.Text.Trim();
            string cpfUsuario = txtCpfUsuario.Text.Trim();
            string orderByUsuario = cmbOrderByUsuario.SelectedItem?.ToString() ?? "";

            string query = @"
        SELECT id, `name`, cpf, phone, email, 'User' as user_type 
        FROM `user` 
        WHERE tenant_id = @tenantId 
        AND (email = @emailDoAdministradorLogado 
            OR (
                (@nomeUsuario IS NULL OR `name` LIKE @nomeUsuario) 
                AND (@cpfUsuario IS NULL OR cpf LIKE @cpfUsuario)
            )
        )
        UNION
        SELECT id, `name`, cpf, phone, email, 'Admin' as user_type 
        FROM `admin` 
        WHERE tenant_id = @tenantId 
        AND (email = @emailDoAdministradorLogado 
            OR (
                (@nomeUsuario IS NULL OR `name` LIKE @nomeUsuario) 
                AND (@cpfUsuario IS NULL OR cpf LIKE @cpfUsuario)
            )
        )
    ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@tenantId", tenantId);
                    command.Parameters.AddWithValue("@emailDoAdministradorLogado", emailLogado);
                    command.Parameters.AddWithValue("@nomeUsuario", string.IsNullOrWhiteSpace(nomeUsuario) ? (object)DBNull.Value : $"%{nomeUsuario}%");
                    command.Parameters.AddWithValue("@cpfUsuario", string.IsNullOrWhiteSpace(cpfUsuario) ? (object)DBNull.Value : $"%{cpfUsuario}%");

                    connection.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            dgvUsuarios.DataSource = table;

                            // Configurar as colunas do DataGridView
                            dgvUsuarios.Columns["id"].Visible = false; // Ocultar a coluna ID
                            dgvUsuarios.Columns["name"].HeaderText = "Nome";
                            dgvUsuarios.Columns["cpf"].HeaderText = "CPF";
                            dgvUsuarios.Columns["phone"].HeaderText = "Telefone";
                            dgvUsuarios.Columns["email"].HeaderText = "Email";
                            dgvUsuarios.Columns["user_type"].HeaderText = "Tipo de Usuário";
                        }
                        else
                        {
                            MessageBox.Show("Nenhum dado encontrado.");
                            dgvUsuarios.DataSource = null;
                        }

                        // Verificações adicionais
                        dgvUsuarios.Visible = true;
                        dgvUsuarios.Enabled = true;
                        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvUsuarios.Dock = DockStyle.Fill;
                        dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        dgvUsuarios.AutoGenerateColumns = true;
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

                    string sql = "SELECT tenant_id FROM admin WHERE email = @usuario";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuario", email);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível encontrar o tenant_id para o administrador logado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1;
                        }
                    }
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
    }
}