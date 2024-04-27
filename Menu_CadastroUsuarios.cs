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
    public partial class frm_Usuario : Form
    {
        public frm_Usuario()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Usuario_Click(object sender, EventArgs e)
        {
            frm_Inicio formInicio = new frm_Inicio();
            formInicio.Show();
            this.Hide();
        }
    }
}
