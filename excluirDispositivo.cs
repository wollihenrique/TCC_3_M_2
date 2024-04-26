using System;
using System.Windows.Forms;

namespace TCC_3_M
{
    public partial class frm_ExcluirDispositivo : Form
    {
        public frm_ExcluirDispositivo()
        {
            InitializeComponent();
        }

        private void btn_Excluir_ExcluirDisp_Click(object sender, EventArgs e)
        {

        }

        private void btn_Voltar_ExcluirDisp_Click(object sender, EventArgs e)
        {
            frm_Inicio frmInicio = new frm_Inicio();
            frmInicio.Show();
            this.Hide();
        }
    }
}
