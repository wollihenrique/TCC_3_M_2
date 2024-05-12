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
    public partial class frm_Inicio : Form
    {
        public frm_Inicio()
        {
            InitializeComponent();
        }

        private void btnCadastrarDispositivo_Click(object sender, EventArgs e)
        {
            frm_CadastroDisp frm_Inicio = new frm_CadastroDisp();
            frm_Inicio.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frm_ExcluirDispositivo frmExcluirDisp = new frm_ExcluirDispositivo();
            frmExcluirDisp.Show();
            this.Hide();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            frm_Usuario formUsuario = new frm_Usuario();
            formUsuario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Login formLogin = new frm_Login();
            formLogin.Show();
            this.Hide();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque formEstoque = new frmEstoque();
            formEstoque.Show();
            this.Hide();
        }
    }
}
