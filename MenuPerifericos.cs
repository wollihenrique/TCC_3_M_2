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
    public partial class frm_Perifericos : Form
    {
        public frm_Perifericos()
        {
            InitializeComponent();
        }

        private void btnVoltarPerifericos_Click(object sender, EventArgs e)
        {
            frm_Inicio formMenu = new frm_Inicio();
            formMenu.Show();
            this.Hide();
        }
    }
}
