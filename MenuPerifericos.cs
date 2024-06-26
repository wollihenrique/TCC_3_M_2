﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCC_3_M
{
    public partial class frm_Menu_Perifericos : Form
    {
        private string connectionString = "server=localhost;database=inventory_system;user=root;password=etec;";
        private int tenantId;

        public frm_Menu_Perifericos(string emailDoAdministradorLogado, int tenantId)
        {
            InitializeComponent();
            this.tenantId = tenantId;

            DesvincularEventos();
            VincularEventos();

            PreencherComboBoxStatus();
            PreencherComboBoxOrderBy();
            PreencherComboBoxTipo();
            PreencherComboBoxUsuarios();
            LoadPeripheralsData();
        }

        private void VincularEventos()
        {
            cmbStatusPerifericos.SelectedIndexChanged += cmbStatusPerifericos_SelectedIndexChanged;
            cmbOrderByPerifericos.SelectedIndexChanged += cmbOrderByPerifericos_SelectedIndexChanged;
            cmbTipoPerifericos.SelectedIndexChanged += cmbTipoPerifericos_SelectedIndexChanged;
            txtModeloPerifericos.TextChanged += txtModeloPerifericos_TextChanged;
            btnExcluirPeriferico.Click += btnExcluirPeriferico_Click;
            btnAtualizarPeriferico.Click += btnAtualizarPeriferico_Click;
            btnEditarRegistroPerifericos.Click += btnEditarRegistroPerifericos_Click;
            btnNovoPeriferico.Click += btnNovoPeriferico_Click;
            btnCloseMenuPerifericos.Click += btnCloseMenuPerifericos_Click;
        }

        private void DesvincularEventos()
        {
            cmbStatusPerifericos.SelectedIndexChanged -= cmbStatusPerifericos_SelectedIndexChanged;
            cmbOrderByPerifericos.SelectedIndexChanged -= cmbOrderByPerifericos_SelectedIndexChanged;
            cmbTipoPerifericos.SelectedIndexChanged -= cmbTipoPerifericos_SelectedIndexChanged;
            txtModeloPerifericos.TextChanged -= txtModeloPerifericos_TextChanged;
            btnExcluirPeriferico.Click -= btnExcluirPeriferico_Click;
            btnAtualizarPeriferico.Click -= btnAtualizarPeriferico_Click;
            btnEditarRegistroPerifericos.Click -= btnEditarRegistroPerifericos_Click;
            btnNovoPeriferico.Click -= btnNovoPeriferico_Click;
            btnCloseMenuPerifericos.Click -= btnCloseMenuPerifericos_Click;
        }

        private void LoadPeripheralsData(string statusFilter = "", string orderBy = "")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.id, p.batch_id, p.type, p.model, p.status, b.entering_date,
                            CONCAT(COALESCE(u.name, ''), COALESCE(a.name, '')) AS user_name
                            FROM peripherals p
                            JOIN batch b ON p.batch_id = b.id
                            LEFT JOIN entity_user_hardware_peripherals eup ON p.id = eup.peripherals_id
                            LEFT JOIN entity_admin_hardware_peripherals eap ON p.id = eap.peripherals_id
                            LEFT JOIN `user` u ON eup.user_id = u.id
                            LEFT JOIN `admin` a ON eap.admin_id = a.id
                            WHERE b.tenant_id = @TenantId"; // Filtra pelo tenantId

                    if (!string.IsNullOrEmpty(statusFilter))
                    {
                        query += $" AND p.status = '{statusFilter}'";
                    }

                    if (!string.IsNullOrEmpty(orderBy))
                    {
                        switch (orderBy)
                        {
                            case "Mais recentes":
                                query += " ORDER BY b.entering_date DESC";
                                break;
                            case "Mais antigos":
                                query += " ORDER BY b.entering_date ASC";
                                break;
                            case "Este mês":
                                query += " AND MONTH(b.entering_date) = MONTH(NOW())";
                                break;
                            case "Este ano":
                                query += " AND YEAR(b.entering_date) = YEAR(NOW())";
                                break;
                        }
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenantId", tenantId);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPerifericos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void PreencherComboBoxStatus()
        {
            cmbStatusPerifericos.Items.AddRange(new string[] { "Em Uso", "Estoque", "Defeituoso", "Manutenção" });
            cmbStatusPerifericos.SelectedIndex = -1;
        }

        private void PreencherComboBoxOrderBy()
        {
            cmbOrderByPerifericos.Items.AddRange(new string[] { "Mais recentes", "Mais antigos", "Este mês", "Este ano" });
            cmbOrderByPerifericos.SelectedIndex = -1;
        }

        private void PreencherComboBoxTipo()
        {
            cmbTipoPerifericos.Items.Clear();
            string[] tipos = { "Monitor", "Teclado", "Mouse", "Impressora", "Scanner", "Webcam", "Headset", "Caixa de som", "Pendrive", "HD Externo", "Microfone" };

            cmbTipoPerifericos.Items.AddRange(tipos);
            cmbTipoPerifericos.SelectedIndex = -1;
        }

        private void PreencherComboBoxUsuarios()
        {
            cmbUsuario.Items.Clear();
            string query = "SELECT name FROM `admin` WHERE tenant_id = @TenantId " +
                           "UNION " +
                           "SELECT name FROM `user` WHERE tenant_id = @TenantId";

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
                        string userName = reader["name"].ToString();
                        cmbUsuario.Items.Add(userName);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao preencher ComboBox de usuários: " + ex.Message);
                }
            }
        }

        private void cmbStatusPerifericos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPeripheralsData(cmbStatusPerifericos.SelectedItem?.ToString(), cmbOrderByPerifericos.SelectedItem?.ToString());
        }

        private void cmbOrderByPerifericos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPeripheralsData(cmbStatusPerifericos.SelectedItem?.ToString(), cmbOrderByPerifericos.SelectedItem?.ToString());
        }

        private void cmbTipoPerifericos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSelecionado = cmbTipoPerifericos.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.id, p.batch_id, p.type, p.model, p.status, b.entering_date, 
                                    CONCAT(COALESCE(u.name, ''), COALESCE(a.name, '')) AS user_name
                                     FROM peripherals p
                                     JOIN batch b ON p.batch_id = b.id
                                     LEFT JOIN entity_user_hardware_peripherals eup ON p.id = eup.peripherals_id
                                     LEFT JOIN entity_admin_hardware_peripherals eap ON p.id = eap.peripherals_id
                                     LEFT JOIN `user` u ON eup.user_id = u.id
                                     LEFT JOIN `admin` a ON eap.admin_id = a.id
                                     WHERE p.type = @Tipo
                                     AND b.tenant_id = @TenantId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Tipo", tipoSelecionado);
                    cmd.Parameters.AddWithValue("@TenantId", tenantId);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPerifericos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtModeloPerifericos_TextChanged(object sender, EventArgs e)
        {
            string modeloDigitado = txtModeloPerifericos.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.id, p.batch_id, p.type, p.model, p.status, b.entering_date, 
                            CONCAT(COALESCE(u.name, ''), COALESCE(a.name, '')) AS user_name
                            FROM peripherals p
                            JOIN batch b ON p.batch_id = b.id
                            LEFT JOIN entity_user_hardware_peripherals eup ON p.id = eup.peripherals_id
                            LEFT JOIN entity_admin_hardware_peripherals eap ON p.id = eap.peripherals_id
                            LEFT JOIN `user` u ON eup.user_id = u.id
                            LEFT JOIN `admin` a ON eap.admin_id = a.id
                            WHERE p.model LIKE @Modelo
                            AND b.tenant_id = @TenantId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Modelo", "%" + modeloDigitado + "%");
                    cmd.Parameters.AddWithValue("@TenantId", tenantId);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPerifericos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnNovoPeriferico_Click(object sender, EventArgs e)
        {
            frm_RegistroPeriferico formNovoPeriferico = new frm_RegistroPeriferico(tenantId);
            formNovoPeriferico.ShowDialog();
            LoadPeripheralsData();
        }

        private void btnEditarRegistroPerifericos_Click(object sender, EventArgs e)
        {
            if (dgvPerifericos.SelectedRows.Count > 0)
            {
                int perifericoId = Convert.ToInt32(dgvPerifericos.SelectedRows[0].Cells["id"].Value);

                frm_EditarPerifericos editarPerifericoForm = new frm_EditarPerifericos(perifericoId, tenantId);
                editarPerifericoForm.ShowDialog();
                LoadPeripheralsData();
            }
            else
            {
                MessageBox.Show("Selecione um periférico para editar.");
            }
        }

        private void btnCloseMenuPerifericos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizarPeriferico_Click(object sender, EventArgs e)
        {
            cmbOrderByPerifericos.SelectedIndex = -1;
            cmbStatusPerifericos.SelectedIndex = -1;
            cmbTipoPerifericos.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;

            LoadPeripheralsData();
        }

        private void btnExcluirPeriferico_Click(object sender, EventArgs e)
        {
            if (dgvPerifericos.SelectedRows.Count > 0)
            {
                int idPeriferico = Convert.ToInt32(dgvPerifericos.SelectedRows[0].Cells["id"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este periférico?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ExcluirPeriferico(idPeriferico);
                    LoadPeripheralsData();
                }
            }
            else
            {
                MessageBox.Show("Selecione um periférico para excluir.");
            }
        }

        private void ExcluirPeriferico(int idPeriferico)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM peripherals WHERE id = @PerifericoId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PerifericoId", idPeriferico);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Periférico excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir periférico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir periférico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedItem != null)
            {
                string userName = cmbUsuario.SelectedItem.ToString();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = @"SELECT p.id, p.batch_id, p.type, p.model, p.status, b.entering_date, 
                        CONCAT(COALESCE(u.name, ''), COALESCE(a.name, '')) AS user_name
                        FROM peripherals p
                        JOIN batch b ON p.batch_id = b.id
                        LEFT JOIN entity_user_hardware_peripherals eup ON p.id = eup.peripherals_id
                        LEFT JOIN entity_admin_hardware_peripherals eap ON p.id = eap.peripherals_id
                        LEFT JOIN `user` u ON eup.user_id = u.id
                        LEFT JOIN `admin` a ON eap.admin_id = a.id
                        WHERE (u.name = @UserName OR a.name = @UserName)
                        AND b.tenant_id = @TenantId";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@TenantId", tenantId);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvPerifericos.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
