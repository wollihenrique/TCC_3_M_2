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

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            frm_CadastroAdmin login = new frm_CadastroAdmin();
            login.Show();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            inicio login = new inicio();
            login.Show();
        }

    }
}
