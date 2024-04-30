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
    public partial class frm_CadastroDisp : Form
    {

        public frm_CadastroDisp()
        {
            InitializeComponent();
        }

        private void btn_NovoUsuario_Click(object sender, EventArgs e)
        {
            frm_RegistroDisp frm_CadastroDisp = new frm_RegistroDisp();
            frm_CadastroDisp.Show();
        }

        private void btn_Voltar_Usuario_Click(object sender, EventArgs e)
        {
            frm_Inicio frm_CadastroDisp = new frm_Inicio();
            frm_CadastroDisp.Show();
            this.Hide();
        }

        private void btn_Voltar_Hist_Disp_Click(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedIndex = 0;
        }

        private void btn_Novo_CastroDisp_Click(object sender, EventArgs e)
        {
            frm_RegistroDisp formCadastroDisp = new frm_RegistroDisp();
            formCadastroDisp.Show();
        }
    }
}
