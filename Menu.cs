using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCC_3_M
{
    public partial class frm_Inicio : Form
    {
        private string emailLogado;
        private int tenantIdLogado;

        private string connectionString = "server=localhost;database=inventory_system;uid=root;password=etec";

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

        public void DefinirEmailLogado(string email, int tenantId)
        {
            emailLogado = email;
            tenantIdLogado = tenantId;
            AtualizarNomeUsuario(); // Atualiza o nome do usuário no botão
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
            // Verifica se o usuário atual é um administrador
            if (VerificarTipoUsuario(emailLogado, tenantIdLogado) == "Admin")
            {
                frm_Usuario frmUsuario = new frm_Usuario(emailLogado);
                openChildForm(frmUsuario);
            }
            else
            {
                MessageBox.Show("Apenas usuários administradores podem acessar essa funcionalidade.");
            }
        }

        private string VerificarTipoUsuario(string email, int tenantId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sql = @"
                SELECT user_type
                FROM (
                    SELECT 'Admin' as user_type, email, tenant_id FROM admin
                    UNION
                    SELECT 'User' as user_type, email, tenant_id FROM user
                ) AS combined_users 
                WHERE email = @usuario AND tenant_id = @tenantId";

                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@usuario", email);
                    cmd.Parameters.AddWithValue("@tenantId", tenantId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return "User";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao verificar o tipo de usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "User";
                }
            }
        }

        private void btnDispositivos_Click(object sender, EventArgs e)
        {
            frm_CadastroDisp frmCadastroDisp = new frm_CadastroDisp(emailLogado, tenantIdLogado);
            openChildForm(frmCadastroDisp);
        }

        private void btnPerifericos_Click(object sender, EventArgs e)
        {
            frm_Menu_Perifericos frmMenuPerifericos = new frm_Menu_Perifericos(emailLogado, tenantIdLogado);
            openChildForm(frmMenuPerifericos);
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            frm_MenuFornecedores frmMenuFornecedores = new frm_MenuFornecedores(emailLogado, tenantIdLogado);
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Login login = new frm_Login();
            login.Show();
        }

        private void AtualizarNomeUsuario()
        {
            string nomeUsuario = ObterPrimeiroNomeUsuario(emailLogado, tenantIdLogado);
            button1.Text = nomeUsuario;
        }

        private string ObterPrimeiroNomeUsuario(string email, int tenantId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sql = @"
                        SELECT name
                        FROM (
                            SELECT name, email, tenant_id FROM admin
                            UNION
                            SELECT name, email, tenant_id FROM user
                        ) AS combined_users 
                        WHERE email = @usuario AND tenant_id = @tenantId";

                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@usuario", email);
                    cmd.Parameters.AddWithValue("@tenantId", tenantId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string nomeCompleto = result.ToString();
                        string primeiroNome = nomeCompleto.Split(' ')[0]; // Pega o primeiro nome
                        return primeiroNome;
                    }
                    else
                    {
                        return "Usuário"; // Valor padrão caso o nome não seja encontrado
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter o nome do usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "Usuário";
                }
            }
        }
    }
}