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
    public partial class frm_Editar_Dispositivos : Form
    {
        private DataRow hardwareData;

        public frm_Editar_Dispositivos(DataRow hardwareData)
        {
            InitializeComponent();
            this.hardwareData = hardwareData;
            LoadHardwareData();
        }

        private void LoadHardwareData()
        {
            txtTagHardware.Text = hardwareData["tag"].ToString();
            txtGarantiaHardware.Text = hardwareData["assurance"].ToString();
            txtModeloHardware.Text = hardwareData["model"].ToString();
            txtMarcaHardware.Text = hardwareData["brand"].ToString();
            cmbStatusHardware.Text = hardwareData["status"].ToString();
            txtProcessadorHardware.Text = hardwareData["processor"].ToString();
            txtRamHardware.Text = hardwareData["ram"].ToString();
            txtDiscoHardware.Text = hardwareData["disk"].ToString();
            txtPVideoHardware.Text = hardwareData["video_card"].ToString();
            txtPRedeHardware.Text = hardwareData["network_card"].ToString();
            txtObsHardware.Text = hardwareData["observations"].ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizarHardware_Click_1(object sender, EventArgs e)
        {
            try
            {
                string tag = txtTagHardware.Text.Trim();
                string assurance = txtGarantiaHardware.Text.Trim();
                string model = txtModeloHardware.Text.Trim();
                string brand = txtMarcaHardware.Text.Trim();
                string status = cmbStatusHardware.Text.Trim();
                string processor = txtProcessadorHardware.Text.Trim();
                string ram = txtRamHardware.Text.Trim();
                string disk = txtDiscoHardware.Text.Trim();
                string videoCard = txtPVideoHardware.Text.Trim();
                string networkCard = txtPRedeHardware.Text.Trim();
                string observations = txtObsHardware.Text.Trim();

                using (MySqlConnection connection = new MySqlConnection("server=localhost;database=inventory_system;user=root;password=etec"))
                {
                    connection.Open();

                    string query = @"
                        UPDATE hardware
                        SET assurance = @assurance, model = @model, brand = @brand, status = @status,
                            processor = @processor, ram = @ram, disk = @disk, video_card = @videoCard,
                            network_card = @networkCard, observations = @observations
                        WHERE tag = @tag";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@tag", tag);
                    cmd.Parameters.AddWithValue("@assurance", assurance);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@processor", processor);
                    cmd.Parameters.AddWithValue("@ram", ram);
                    cmd.Parameters.AddWithValue("@disk", disk);
                    cmd.Parameters.AddWithValue("@videoCard", videoCard);
                    cmd.Parameters.AddWithValue("@networkCard", networkCard);
                    cmd.Parameters.AddWithValue("@observations", observations);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dados atualizados com sucesso!");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum dado foi atualizado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar os dados: " + ex.Message);
            }
        }
    }
}