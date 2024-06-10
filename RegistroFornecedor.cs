using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCC_3_M
{
    public partial class frm_RegistroFornecedor : Form
    {
        private string connectionString = "server=localhost;database=inventory_system;uid=root;pwd=vini;";

        public frm_RegistroFornecedor()
        {
            InitializeComponent();
        }

        private void btnCloseFrmCadastroF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarCadF_Click(object sender, EventArgs e)
        {
            string nome = txtNomeF.Text;
            string cnpjCpf = txtCnpjCpfF.Text;
            string telefone = txtTelefoneF.Text;
            string endereco = txtEnderecoF.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cnpjCpf) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(endereco))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarCpfCnpj(cnpjCpf))
            {
                MessageBox.Show("CPF/CNPJ inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO supplier (name, address, phone, document) VALUES (@name, @address, @phone, @document)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", nome);
                        command.Parameters.AddWithValue("@address", endereco);
                        command.Parameters.AddWithValue("@phone", telefone);
                        command.Parameters.AddWithValue("@document", cnpjCpf);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Fornecedor cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimparCadF_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNomeF.Text = "";
            txtCnpjCpfF.Text = "";
            txtTelefoneF.Text = "";
            txtEnderecoF.Text = "";
        }

        private bool ValidarCpfCnpj(string input)
        {
            string cleanInput = Regex.Replace(input, "[^0-9]", "");

            if (cleanInput.Length != 11 && cleanInput.Length != 14)
                return false;

            if (cleanInput.All(c => c == cleanInput[0]))
                return false;

            if (cleanInput.Length == 11)
            {
                int[] multiplier1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplier2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                string tempCpf = cleanInput.Substring(0, 9);
                int sum = 0;

                for (int i = 0; i < 9; i++)
                {
                    sum += int.Parse(tempCpf[i].ToString()) * multiplier1[i];
                }

                int remainder = sum % 11;
                remainder = remainder < 2 ? 0 : 11 - remainder;

                string digit = remainder.ToString();
                tempCpf += digit;

                sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum += int.Parse(tempCpf[i].ToString()) * multiplier2[i];
                }

                remainder = sum % 11;
                remainder = remainder < 2 ? 0 : 11 - remainder;

                digit += remainder.ToString();

                return cleanInput.EndsWith(digit);
            }
            else
            {
                int[] multiplier1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplier2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                string tempCnpj = cleanInput.Substring(0, 12);
                int sum = 0;

                for (int i = 0; i < 12; i++)
                {
                    sum += int.Parse(tempCnpj[i].ToString()) * multiplier1[i];
                }

                int remainder = sum % 11;
                remainder = remainder < 2 ? 0 : 11 - remainder;

                string digit = remainder.ToString();
                tempCnpj += digit;

                sum = 0;
                for (int i = 0; i < 13; i++)
                {
                    sum += int.Parse(tempCnpj[i].ToString()) * multiplier2[i];
                }

                remainder = sum % 11;
                remainder = remainder < 2 ? 0 : 11 - remainder;

                digit += remainder.ToString();

                return cleanInput.EndsWith(digit);
            }
        }
    }
}