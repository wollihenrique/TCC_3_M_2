﻿using System;
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

        private void btnVoltar_pnlCadastroDevice_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVoltar_pnlCadastroDevice_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Inicio formInicio = new frm_Inicio();
            formInicio.Show();
            this.Hide();
        }
    }
}