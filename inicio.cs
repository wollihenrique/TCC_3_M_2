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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void btnCadastrarDispositivo_Click(object sender, EventArgs e)
        {
            registroDispositivos inicio = new registroDispositivos();
            inicio.Show();
        }
    }
}
