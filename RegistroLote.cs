﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace TCC_3_M
{
    public partial class frm_RegistroLote : Form
    {
        private string connectionString = "server=localhost;database=inventory_system;uid=root;pwd=etec;";

        public frm_RegistroLote()
        {
            InitializeComponent();
            CarregarFornecedores();
        }

        private void btnCloseFrmCadastroLote_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarCadLote_Click(object sender, EventArgs e)
        {
            string nomeLote = txtNomeF.Text;
            string dataRecebimento = txtDataRecebimentoLote.Text;
            string fornecedor = cmbFornecedorLote.Text;

            if (string.IsNullOrEmpty(nomeLote) || string.IsNullOrEmpty(dataRecebimento) || string.IsNullOrEmpty(fornecedor))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarData(dataRecebimento))
            {
                MessageBox.Show("Data de recebimento inválida. Use o formato: dd/mm/aaaa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO batch (id, supplier_id, entering_date, amount) VALUES (@id, @supplier_id, @entering_date, @amount)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", GenerateBatchId());
                        command.Parameters.AddWithValue("@supplier_id", cmbFornecedorLote.SelectedIndex + 1);
                        command.Parameters.AddWithValue("@entering_date", Convert.ToDateTime(dataRecebimento));
                        command.Parameters.AddWithValue("@amount", 0); // Aqui você pode definir a quantidade inicial

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Lote cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar lote: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimparCadLote_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNomeF.Text = "";
            txtDataRecebimentoLote.Text = "";
            cmbFornecedorLote.SelectedIndex = -1;
        }

        private void CarregarFornecedores()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT name FROM supplier";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbFornecedorLote.Items.Add(reader["name"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarData(string data)
        {
            return Regex.IsMatch(data, @"^(0?[1-9]|[12][0-9]|3[01])[/](0?[1-9]|1[012])[/]\d{4}$");
        }

        private string GenerateBatchId()
        {
            Random rnd = new Random();
            return "B" + rnd.Next(1000, 9999).ToString();
        }
    }
}