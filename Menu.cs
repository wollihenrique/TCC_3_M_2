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
        private string emailDoAdministradorLogado;

        public frm_Inicio()
        {
            InitializeComponent();
            customizeDesign();
            // Configura o intervalo do timer para 1 segundo
            timerRelogio.Interval = 1000;

            // Adiciona um manipulador de evento para o evento Tick do Timer
            timerRelogio.Tick += TimerRelogio_Tick;

            // Inicia o timer
            timerRelogio.Start();
        }

        public void DefinirEmailDoAdministrador(string email)
        {
            emailDoAdministradorLogado = email;
        }

        private void TimerRelogio_Tick(object sender, EventArgs e)
        {
            // Atualiza o texto do Label para exibir a hora atual
            labelRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void SeuFormulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Para o timer quando o formulário estiver fechado
            timerRelogio.Stop();
        }

        private void customizeDesign()
        {
            pnlSubUserMenu.Visible = false;
            pnlSubMenuCreditos.Visible = false;
            pnlSubMenuAjuda.Visible = false;
            pnlSubMenuHistoric.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
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
            int tenantId = new frm_Login().ObterTenantId(emailDoAdministradorLogado);
            frm_Usuario frmUsuario = new frm_Usuario(emailDoAdministradorLogado);
            openChildForm(frmUsuario);
        }

        private void btnDispositivos_Click(object sender, EventArgs e)
        {
                int tenantId = new frm_Login().ObterTenantId(emailDoAdministradorLogado);
                frm_CadastroDisp frmCadastroDisp = new frm_CadastroDisp(emailDoAdministradorLogado, tenantId);
                openChildForm(frmCadastroDisp);
        }

        private void btnPerifericos_Click(object sender, EventArgs e)
        {
            int tenantId = new frm_Login().ObterTenantId(emailDoAdministradorLogado);
            frm_MenuPerifericos frmMenuPerifericos = new frm_MenuPerifericos(emailDoAdministradorLogado, tenantId);
            openChildForm(frmMenuPerifericos);
        }
        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            int tenantId = new frm_Login().ObterTenantId(emailDoAdministradorLogado);
            frm_MenuFornecedores frmMenuFornecedores = new frm_MenuFornecedores(emailDoAdministradorLogado, tenantId);
            openChildForm(frmMenuFornecedores);
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
            //hideSubMenu();
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
            //hideSubMenu();
        }

        private void btnTutoriais_Click(object sender, EventArgs e)
        {
            //...
            //...EScrever o resto dos códigos
            //...
            //hideSubMenu();
        }

        private void btnDuvidas_Click(object sender, EventArgs e)
        {
            //...
            //...EScrever o resto dos códigos
            //...
            //hideSubMenu();
        }
        #endregion

        #region MENU HISTÓRICO
        private void btnHistórico_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuHistoric);
        }

        private void btnHistoricRegisters_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Historico());
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
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