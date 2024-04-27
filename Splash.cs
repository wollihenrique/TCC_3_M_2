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
    public partial class frm_Splash : Form
    {
        public frm_Splash()
        {
            InitializeComponent();
        }

        private void frm_Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                lbl_Carregando.Text = progressBar1.Value.ToString() + " % ";
            }

            else
            {
                timer1.Stop();
                this.Hide();
                frm_Login formLogin = new frm_Login();
                formLogin.ShowDialog();
            }
        }
    }
}
