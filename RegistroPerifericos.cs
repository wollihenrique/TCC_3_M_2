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
    public partial class frm_RegistroPeriferico : Form
    {
        private string connectionString = "server=localhost;database=inventory_system;user=root;password=etec;";
        private int tenantId;

        public frm_RegistroPeriferico(int tenantId)
        {
            InitializeComponent();
            this.tenantId = tenantId; // Atribui o tenantId recebido ao campo privado
            PreencherComboBoxTipo();
            PreencherComboBoxStatus();
            PreencherComboBoxLote();
            PreencherComboBoxUsuarios();

            // Inicialmente, esconde a cmbUsuario e lblUsuario
            cmbUsuario.Visible = false;
            lblUsuario.Visible = false;
        }

        private void btnCloseFrmRegistroPerifericos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarFrmCadastroP_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipoFrmCadastroP.SelectedItem?.ToString();
            string modelo = txtModeloCadastroP.Text.Trim();
            string status = cmbStatusFrmCadastroP.SelectedItem?.ToString();
            string loteId = cmbLoteFrmCadastroP.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(loteId))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Primeiro, insere o periférico na tabela peripherals
                    string queryInsertPeripheral = @"INSERT INTO peripherals (batch_id, type, model, status, tenant_id)
                                             VALUES (@BatchId, @Type, @Model, @Status, @TenantId); SELECT LAST_INSERT_ID();";

                    MySqlCommand cmdInsertPeripheral = new MySqlCommand(queryInsertPeripheral, conn);
                    cmdInsertPeripheral.Parameters.AddWithValue("@BatchId", loteId);
                    cmdInsertPeripheral.Parameters.AddWithValue("@Type", tipo);
                    cmdInsertPeripheral.Parameters.AddWithValue("@Model", modelo);
                    cmdInsertPeripheral.Parameters.AddWithValue("@Status", status);
                    cmdInsertPeripheral.Parameters.AddWithValue("@TenantId", tenantId);

                    // Executa o comando e obtém o ID do periférico inserido
                    int peripheralId = Convert.ToInt32(cmdInsertPeripheral.ExecuteScalar());

                    // Em seguida, verifica se há um usuário selecionado e, se sim, associa ao periférico
                    if (cmbUsuario.SelectedItem != null)
                    {
                        var selectedUser = (KeyValuePair<string, KeyValuePair<int, string>>)cmbUsuario.SelectedItem;
                        string userType = selectedUser.Key;
                        int userId = selectedUser.Value.Key;

                        string queryAssociateUser = userType == "admin" ?
                            "INSERT INTO entity_admin_hardware_peripherals (tenant_id, admin_id, peripherals_id) VALUES (@TenantId, @UserId, @PeripheralId);" :
                            "INSERT INTO entity_user_hardware_peripherals (tenant_id, user_id, peripherals_id) VALUES (@TenantId, @UserId, @PeripheralId);";

                        MySqlCommand cmdAssociateUser = new MySqlCommand(queryAssociateUser, conn);
                        cmdAssociateUser.Parameters.AddWithValue("@TenantId", tenantId);
                        cmdAssociateUser.Parameters.AddWithValue("@UserId", userId);
                        cmdAssociateUser.Parameters.AddWithValue("@PeripheralId", peripheralId);

                        cmdAssociateUser.ExecuteNonQuery();
                    }

                    MessageBox.Show("Periférico registrado com sucesso!");
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar periférico: " + ex.Message);
                }
            }
        }

        private void btnCancelarFrmCadastroP_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            cmbTipoFrmCadastroP.SelectedIndex = -1;
            txtModeloCadastroP.Clear();
            cmbStatusFrmCadastroP.SelectedIndex = -1;
            cmbLoteFrmCadastroP.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1; // Limpa a seleção da cmbUsuario
        }

        private void PreencherComboBoxTipo()
        {
            cmbTipoFrmCadastroP.Items.Clear();
            string[] tipos = { "Monitor", "Teclado", "Mouse", "Impressora", "Scanner", "Webcam", "Headset", "Caixa de som", "Pendrive", "HD Externo", "Microfone" };

            cmbTipoFrmCadastroP.Items.AddRange(tipos);
            cmbTipoFrmCadastroP.SelectedIndex = -1;
        }

        private void PreencherComboBoxStatus()
        {
            cmbStatusFrmCadastroP.Items.AddRange(new string[] { "Em Uso", "Estoque", "Defeituoso", "Manutenção" });
            cmbStatusFrmCadastroP.SelectedIndex = -1;
        }

        private void PreencherComboBoxLote()
        {
            cmbLoteFrmCadastroP.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id FROM batch WHERE tenant_id = @TenantId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenantId", tenantId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbLoteFrmCadastroP.Items.Add(reader["id"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar lotes: " + ex.Message);
                }
            }
        }

        private void PreencherComboBoxUsuarios()
        {
            string query = "SELECT 'admin' AS user_type, id, name FROM `admin` WHERE tenant_id = @TenantId " +
                           "UNION ALL " +
                           "SELECT 'user' AS user_type, id, name FROM `user` WHERE tenant_id = @TenantId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenantId", tenantId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string userType = reader["user_type"].ToString();
                        int userId = Convert.ToInt32(reader["id"]);
                        string userName = reader["name"].ToString();
                        cmbUsuario.Items.Add(new KeyValuePair<string, KeyValuePair<int, string>>(userType, new KeyValuePair<int, string>(userId, userName)));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao preencher ComboBox de usuários: " + ex.Message);
                }
            }
        }

        private void cmbStatusFrmCadastroP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cmbStatusFrmCadastroP.SelectedItem?.ToString();

            // Mostra cmbUsuario e lblUsuario apenas se o status for "Em Uso"
            cmbUsuario.Visible = (selectedStatus == "Em Uso");
            lblUsuario.Visible = (selectedStatus == "Em Uso");

            // Limpa a seleção da cmbUsuario se o status não for "Em Uso"
            if (selectedStatus != "Em Uso")
            {
                cmbUsuario.SelectedIndex = -1;
            }
        }
    }
}