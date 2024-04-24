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
    public partial class login : Form
    {
        private cadastroAdmin txt_telaLogin;

        public login()
        {
            InitializeComponent();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            cadastroAdmin login = new cadastroAdmin();
            login.Show();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            inicio login = new inicio();
            login.Show();
        }
    }
}
