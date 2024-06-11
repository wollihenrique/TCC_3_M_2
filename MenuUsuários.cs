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
    public partial class frm_Usuario : Form
    {
        private string connectionString = "Server=localhost;Database=inventory_system;Uid=root;Pwd=etec";

        public frm_Usuario()
        {
            InitializeComponent();
            AtualizarDataGridView();
        }

        private void AtualizarDataGridView()
        {
            string query = "SELECT id, `name`, cpf, phone, email, 'User' as user_type FROM `user` " +
                           "UNION " +
                           "SELECT id, `name`, cpf, phone, email, 'Admin' as user_type FROM `admin`";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvUsuarios.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frm_RegistroUsuario FormRegistroUsuario = new frm_RegistroUsuario();
            FormRegistroUsuario.Show();
        }

        private void btnEditarRegistroUsuario_Click(object sender, EventArgs e)
        {
            frm_EditarUsuario _EditarUsuario = new frm_EditarUsuario();
            _EditarUsuario.Show();
        }

        private void btnAtualizarUsuario_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }
    }
}
