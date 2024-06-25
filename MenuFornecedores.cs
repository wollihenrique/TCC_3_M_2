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
    public partial class frm_MenuFornecedores : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;database=inventory_system;uid=root;pwd=etec;";
        private DataTable dataTable;
        private string emailDoAdministradorLogado; // Campo para armazenar o email do administrador logado
        private int tenantId; // Campo para armazenar o tenantId

        public frm_MenuFornecedores(string emailDoAdministradorLogado, int tenantId)
        {
            InitializeComponent();
            this.emailDoAdministradorLogado = emailDoAdministradorLogado; // Atribui o email recebido ao campo privado
            this.tenantId = tenantId; // Atribui o tenantId recebido ao campo privado
            InitializeDatabase();
            AtualizarDataGridView();
        }

        private void InitializeDatabase()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void AtualizarDataGridView()
        {
            try
            {
                string query = "SELECT * FROM supplier WHERE tenant_id = @TenantId";

                if (!string.IsNullOrEmpty(txtCpfCnpjMenu.Text))
                {
                    query += $" AND document LIKE '%{txtCpfCnpjMenu.Text}%'";
                }

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenantId", tenantId); // Usando o tenantId recebido

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvFornecedor.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados do fornecedor: " + ex.Message);
            }
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            frm_RegistroFornecedor registroFornecedor = new frm_RegistroFornecedor(emailDoAdministradorLogado, tenantId);
            registroFornecedor.Show();
        }

        private void btnAtualizarUsuario_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void txtCpfCnpjMenu_TextChanged(object sender, EventArgs e)
        {
            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = $"document LIKE '%{txtCpfCnpjMenu.Text}%'";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}