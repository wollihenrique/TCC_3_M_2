using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_3_M
{
    public partial class frm_RegistroDisp : Form
    {

        private const int FormWidthNormal = 605; // Largura normal do formulário
        private const int FormHeightNormal = 260; // Altura normal do formulário
        private const int FormWidthExpandido = 605; // Largura expandida do formulário
        private const int FormHeightExpandido = 500; // Altura expandida do formulário

        private bool painelVisivel = false;

        public frm_RegistroDisp()
        {
            InitializeComponent();
            OcultarPainel();
        }

        private void btn_Cancelar_RegistroDisp_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            // Ajustar o tamanho do formulário para incluir o painel
            this.Size = new Size(FormWidthExpandido, FormHeightExpandido);

            // Mostrar o painel e ajustar sua visibilidade
            panelHardwareInfos.Visible = true;
            painelVisivel = true;
        }

        private void OcultarPainel()
        {
            //Ocultar Painel
            panelHardwareInfos.Visible = false;
            painelVisivel = false;

            //Redimensionar o formulário para o tamanho normal
            this.Size = new Size(FormWidthNormal, FormHeightNormal);
        }
    }
}
