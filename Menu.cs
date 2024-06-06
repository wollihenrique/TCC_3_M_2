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
            customizeDesign();
        }

        private void customizeDesign()
        {
            pnlSubUserMenu.Visible = false;
            pnlSubMenuCreditos.Visible = false;
            pnlSubMenuAjuda.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlSubUserMenu.Visible == true)
                pnlSubUserMenu.Visible = false;
            if (pnlSubMenuAjuda.Visible == true)
                pnlSubMenuAjuda.Visible = false;
            if (pnlSubMenuCreditos.Visible == true)
                pnlSubMenuCreditos.Visible = false;
        }

        private void showSubMenu( Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }

            else
                subMenu.Visible = false;
        }

        #region MENU REGISTROS
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubUserMenu);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Usuario());
            //...EScrever o resto dos códigos
            //...
            hideSubMenu();
        }

        private void btnDispositivos_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_CadastroDisp());
            //...EScrever o resto dos códigos
            //...
            hideSubMenu();
        }

        private void btnPerifericos_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_MenuPerifericos());
            //...EScrever o resto dos códigos
            //...
            hideSubMenu();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_RegistroFornecedor());
            hideSubMenu();
        }
        #endregion

        #region MENU CRÉDITOS
        private void btnCreditos_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuCreditos);
        }

        private void btnNossaEquipe_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Creditos());
            //...EScrever o resto dos códigos
            //...
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //...
            //...EScrever o resto dos códigos
            //...
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //...
            //...EScrever o resto dos códigos
            //...
            hideSubMenu();
        }
        #endregion

        #region MENU AJUDA
        private void btnAjuda_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuAjuda);
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            //...
            //...EScrever o resto dos códigos
            //...
            hideSubMenu();
        }

        private void btnTutoriais_Click(object sender, EventArgs e)
        {
            //...
            //...EScrever o resto dos códigos
            //...
            hideSubMenu();
        }

        private void btnDuvidas_Click(object sender, EventArgs e)
        {
            //...
            //...EScrever o resto dos códigos
            //...
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm( Form childForm )
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlFilhoConteinerPrincipal.Controls.Add(childForm);
            pnlFilhoConteinerPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Login login = new frm_Login();
            login.Show();
        }
    }
}