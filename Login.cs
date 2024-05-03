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
    public partial class frm_Login : Form
    {

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Log_Click(object sender, EventArgs e)
        {
            frm_Inicio frm_Inicio = new frm_Inicio();
            frm_Inicio.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_CadastroAdmin formCadastroAdmin = new frm_CadastroAdmin();
            formCadastroAdmin.Show();
            this.Hide();
        }

        private void txtSenha_CadastroAdmin_TextChanged(object sender, EventArgs e)
        {
            txtSenha_CadastroAdmin.PasswordChar = '*';
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
