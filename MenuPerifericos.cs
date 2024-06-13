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
    public partial class frm_MenuPerifericos : Form
    {
        public frm_MenuPerifericos()
        {
            InitializeComponent();
        }

        private void btnNovoPeriferico_Click(object sender, EventArgs e)
        {
            frm_RegistroPeriferico formNovoPeriferico = new frm_RegistroPeriferico();
            formNovoPeriferico.Show();
        }

        private void btnExcluirPeriferico_Click(object sender, EventArgs e)
        {
            frm_ExcluirPerifericos formExcluirPeriferico = new frm_ExcluirPerifericos();
            formExcluirPeriferico.Show();
        }

        private void btnEditarRegistroPerifericos_Click(object sender, EventArgs e)
        {
            frm_EditarPerifericos formEditarPerifericos = new frm_EditarPerifericos();
            formEditarPerifericos.Show();
        }

        private void btnCloseMenuPerifericos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
