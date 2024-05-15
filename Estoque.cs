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
    public partial class frm_Estoque : Form
    {
        public frm_Estoque()
        {
            InitializeComponent();
        }

        private void btnHardwareEstoque_Click(object sender, EventArgs e)
        {
            pnlHardware_Estoque.Visible = true;
        }

        private void btnVoltarEstoque_Click_1(object sender, EventArgs e)
        {
            if(pnlHardware_Estoque.Visible == true)
            {
                pnlHardware_Estoque.Visible = false;
            }
        }

        private void btnVoltarCreditos_Click(object sender, EventArgs e)
        {
            frm_Inicio formInicio = new frm_Inicio();
            formInicio.Show();
            this.Hide();
        }
    }
}
