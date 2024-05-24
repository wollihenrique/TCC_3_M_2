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

        private void btn_Novo_CastroDisp_Click(object sender, EventArgs e)
        {
            frm_RegistroDisp formRegistroHardware = new frm_RegistroDisp();
            formRegistroHardware.Show();
        }

        private void btn_Voltar_CadastroDisp_Click(object sender, EventArgs e)
        {
            frm_Inicio frm_CadastroDisp = new frm_Inicio();
            frm_CadastroDisp.Show();
            this.Hide();
        }

        private void btn_Pesquisar_CadastroDispo_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoHardware_Click(object sender, EventArgs e)
        {
            frm_RegistroDisp registroDisp = new frm_RegistroDisp();
            registroDisp.Show();
        }
    }
}
