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
        }
        
        private void add_UControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userControl);
            userControl.BringToFront(); 
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            foreach (var pnl in tableLayoutMenu.Controls.OfType<Panel> ())
            {
                pnl.BackColor = Color.Silver;
            }

            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnUsuariosH":
                    add_UControls(new UC_Usuarios());
                    pnlUsuariosH.BackColor = Color.CornflowerBlue;
                    break;
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
                    pnlLotes.BackColor = Color.CornflowerBlue;
                    break;
            }
        }

        private void btnCloseHistoric_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
