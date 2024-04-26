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

        private void btn_Cadastro_Log_Click(object sender, EventArgs e)
        {
            frm_CadastroAdmin frm_Cadastro = new frm_CadastroAdmin();
            frm_Cadastro.Show();
            this.Hide();
        }

        private void btn_Entrar_Log_Click(object sender, EventArgs e)
        {
            frm_Inicio frm_Inicio = new frm_Inicio();
            frm_Inicio.Show();
            this.Hide();
        }

    }
}
