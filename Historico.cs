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
    public partial class frm_Historico : Form
    {
        public frm_Historico()
        {
            InitializeComponent();
           // pnlMain.Visible = false;
        }

        private void add_UControls(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            //pnlMain.Visible = true;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
            uc.BringToFront();  
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            foreach(var pnl in tableLayoutPanel1.Controls.OfType<Panel>())
                 pnl.BackColor = Color.Silver;

            Button btn = (Button)sender;
            switch(btn.Name)
            {
                case "btnDispositivosH":
                    add_UControls(new UC_Dispositivos());
                    pnlDispositivosH.BackColor = Color.CornflowerBlue;
                    break;
                case "btnPerifericosH":
                    add_UControls(new UC_Perifericos());
                    pnlPerifericosH.BackColor = Color.CornflowerBlue;
                    break;
                case "btnFornecedoresH":
                    add_UControls(new UC_Fornecedores());
                    pnlFornecedoresH.BackColor = Color.CornflowerBlue;
                    break;
                case "btnLotesH":
                    add_UControls(new UC_Lotes());
                    pnlLotesH.BackColor = Color.CornflowerBlue;
                    break;
                case "BtnFuncionariosH":
                    add_UControls(new UC_Funcionarios());
                    pnlFuncionariosH.BackColor = Color.CornflowerBlue;
                    break;
            }
        }

        private void btnCloseHistoric_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
