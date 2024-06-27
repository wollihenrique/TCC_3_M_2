using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TCC_3_M
{
    public partial class frm_RegistroDisp : Form
    {
        private const int FormWidthNormal = 605;
        private const int FormHeightNormal = 260;
        private const int FormWidthExpandido = 605;
        private const int FormHeightExpandido = 500;
        private bool painelVisivel = false;
        private int tenantId;

        public frm_RegistroDisp(int tenantId)
        {
            InitializeComponent();
            this.tenantId = tenantId;
            OcultarPainel();
            PreencherComboBoxStatus();
            PreencherComboBoxLote();
            PreencherComboBoxUsuarios();
            cmbUsuario.Visible = false;
            lblUsuario.Visible = false;
        }

        private void PreencherComboBoxStatus()
        {
            string connectionString = "server=localhost;database=inventory_system;uid=root;pwd=etec;";
            string query = "SELECT COLUMN_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'hardware' AND COLUMN_NAME = 'status'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    string columnType = cmd.ExecuteScalar().ToString();
                    string[] enumValues = columnType.Replace("enum(", "").Replace(")", "").Replace("'", "").Split(',');
                    cmbStatusCadH.Items.AddRange(enumValues);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao preencher ComboBox de status: " + ex.Message);
                }
            }
        }

        private void PreencherComboBoxLote()
        {
            string connectionString = "server=localhost;database=inventory_system;uid=root;pwd=etec;";
            string query = "SELECT id FROM batch WHERE tenant_id = @TenantId";

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
                        cmbLote.Items.Add(reader["id"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao preencher ComboBox de lote: " + ex.Message);
                }
            }
        }

        private void PreencherComboBoxUsuarios()
        {
            string connectionString = "server=localhost;database=inventory_system;uid=root;pwd=etec;";
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao preencher ComboBox de usuários: " + ex.Message);
                }
            }
        }

        private void btnVoltarPnlCadastroDevice_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!painelVisivel)
            {
                MostrarPainel();
                panelHardwareInfos.Visible = true;
            }
            else
            {
                OcultarPainel();
                panelHardwareInfos.Visible = false;
            }
        }

        private void MostrarPainel()
        {
            this.Size = new System.Drawing.Size(FormWidthExpandido, FormHeightExpandido);
            panelHardwareInfos.Visible = true;
            painelVisivel = true;
        }

        private void OcultarPainel()
        {
            panelHardwareInfos.Visible = false;
            painelVisivel = false;
            this.Size = new System.Drawing.Size(FormWidthNormal, FormHeightNormal);
        }

        private void btnSalvarCadH_Click(object sender, EventArgs e)
        {
            // Validação dos campos obrigatórios
            if (string.IsNullOrEmpty(txtTagCadH.Text) ||
                string.IsNullOrEmpty(txtModeloCadH.Text) ||
                string.IsNullOrEmpty(txtMarcaCadH.Text) ||
                cmbStatusCadH.SelectedItem == null ||
                cmbLote.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            string connectionString = "server=localhost;database=inventory_system;uid=root;pwd=etec;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string queryInsertHardware = @"
                        INSERT INTO hardware (tag, batch_id, assurance, model, brand, status, processor, ram, disk, video_card, network_card, observations, tenant_id)
                        VALUES (@tag, @batch_id, @assurance, @model, @brand, @status, @processor, @ram, @disk, @video_card, @network_card, @observations, @tenantId);";

                    MySqlCommand cmdInsertHardware = new MySqlCommand(queryInsertHardware, conn);
                    cmdInsertHardware.Parameters.AddWithValue("@tag", txtTagCadH.Text);
                    cmdInsertHardware.Parameters.AddWithValue("@batch_id", cmbLote.SelectedItem.ToString());
                    cmdInsertHardware.Parameters.AddWithValue("@assurance", string.IsNullOrEmpty(txtGarantiaCadH.Text) ? DBNull.Value : (object)txtGarantiaCadH.Text);
                    cmdInsertHardware.Parameters.AddWithValue("@model", txtModeloCadH.Text);
                    cmdInsertHardware.Parameters.AddWithValue("@brand", txtMarcaCadH.Text);
                    cmdInsertHardware.Parameters.AddWithValue("@status", cmbStatusCadH.SelectedItem.ToString());
                    cmdInsertHardware.Parameters.AddWithValue("@processor", string.IsNullOrEmpty(txtProcessadorCadH.Text) ? DBNull.Value : (object)txtProcessadorCadH.Text);
                    cmdInsertHardware.Parameters.AddWithValue("@ram", string.IsNullOrEmpty(txtRamCadH.Text) ? DBNull.Value : (object)txtRamCadH.Text);
                    cmdInsertHardware.Parameters.AddWithValue("@disk", string.IsNullOrEmpty(txtDiscoCadH.Text) ? DBNull.Value : (object)txtDiscoCadH.Text);
                    cmdInsertHardware.Parameters.AddWithValue("@video_card", string.IsNullOrEmpty(txtPVideoCadH.Text) ? DBNull.Value : (object)txtPVideoCadH.Text);
                    cmdInsertHardware.Parameters.AddWithValue("@network_card", string.IsNullOrEmpty(txtPRedeCadH.Text) ? DBNull.Value : (object)txtPRedeCadH.Text);
                    cmdInsertHardware.Parameters.AddWithValue("@observations", string.IsNullOrEmpty(txtObsCadH.Text) ? DBNull.Value : (object)txtObsCadH.Text);
                    cmdInsertHardware.Parameters.AddWithValue("@tenantId", tenantId);

                    cmdInsertHardware.ExecuteNonQuery();

                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar dados: " + ex.Message);
                }
            }
        }

        private void btnLimparCadH_Click(object sender, EventArgs e)
        {
            txtTagCadH.Text = "";
            txtModeloCadH.Text = "";
            txtMarcaCadH.Text = "";
            txtProcessadorCadH.Text = "";
            txtDiscoCadH.Text = "";
            txtRamCadH.Text = "";
            txtPVideoCadH.Text = "";
            txtPRedeCadH.Text = "";
            txtGarantiaCadH.Text = "";
            txtObsCadH.Text = "";
            cmbStatusCadH.SelectedIndex = -1;
            cmbLote.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
        }

        private void cmbStatusCadH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatusCadH.SelectedItem != null && cmbStatusCadH.SelectedItem.ToString().Equals("Em uso", StringComparison.OrdinalIgnoreCase))
            {
                cmbUsuario.Visible = true;
                lblUsuario.Visible = true;
            }
            else
            {
                cmbUsuario.Visible = false;
                lblUsuario.Visible = false;
                cmbUsuario.SelectedItem = null;
            }
        }
    }
}