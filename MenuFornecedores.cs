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
                string query = @"
        SELECT 
            s.id AS FornecedorId, 
            s.name AS NomeFornecedor, 
            s.document AS DocumentoFornecedor, 
            b.id AS LoteId, 
            b.entering_date AS DataEntradaLote,
            b.amount AS QuantidadeLote
        FROM 
            supplier s
            LEFT JOIN batch b ON s.id = b.supplier_id
        WHERE 
            s.tenant_id = @TenantId";

                if (!string.IsNullOrEmpty(txtCpfCnpjMenu.Text))
                {
                    query += $" AND s.document LIKE '%{txtCpfCnpjMenu.Text}%'";
                }

                if (!string.IsNullOrEmpty(txtLoteMenu.Text))
                {
                    query += $" AND b.id = @BatchId";
                }

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenantId", tenantId);
                if (!string.IsNullOrEmpty(txtLoteMenu.Text))
                {
                    cmd.Parameters.AddWithValue("@BatchId", txtLoteMenu.Text);
                }

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

        private void txtLoteMenu_TextChanged(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluirRegistroFuncionario_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            {
                int idFornecedor = Convert.ToInt32(dgvFornecedor.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este fornecedor?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM supplier WHERE id = @Id";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Id", idFornecedor);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Fornecedor excluído com sucesso!");
                            AtualizarDataGridView();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para excluir.");
            }
        }

        private void btnNovoLote_Click(object sender, EventArgs e)
        {
            frm_RegistroLote registroLote = new frm_RegistroLote(tenantId);
            registroLote.Show();
        }
    }
}