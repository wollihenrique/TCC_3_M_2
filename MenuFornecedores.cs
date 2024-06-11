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
        private string connectionString = "server=localhost;database=inventory_system;uid=root;pwd=vini;";
        private DataTable dataTable;

        public frm_MenuFornecedores()
        {
            InitializeComponent();
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
                string query = "SELECT * FROM supplier WHERE 1=1";

                if (!string.IsNullOrEmpty(txtCpfCnpjMenu.Text))
                {
                    query += $" AND document LIKE '%{txtCpfCnpjMenu.Text}%'";
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
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
            frm_RegistroFornecedor registroFornecedor = new frm_RegistroFornecedor();
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
    }
}
