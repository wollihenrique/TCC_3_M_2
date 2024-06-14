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
    public partial class frm_Creditos : Form
    {
        public frm_Creditos()
        {
            InitializeComponent();
        }

        private void btnVoltarCreditos_Click(object sender, EventArgs e)
        {
            frm_Inicio frm_Menu = new frm_Inicio();
            frm_Menu.Show();
            this.Hide();
        }

        private void labDescricao_Click(object sender, EventArgs e)
        {
           
            label1.Text = "No projeto, as responsabilidades incluíam foco no desenvolvimento em C#, colaboração com o designer das telas para garantir uma integração fluida entre a lógica de backend e a apresentação visual,\ne contribuições para a documentação abrangente do sistema. Além disso, era crucial manter-se atualizado com as diferentes áreas do projeto,\nincluindo o banco de dados e a integração deste com a camada de C#, assegurando uma sincronia eficiente entre os componentes do sistema.";

            
            label1.AutoSize = false;
           
            label1.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void labAnderson_Click(object sender, EventArgs e)
        {
            label1.Text = "No projeto, as responsabilidades incluíam foco no desenvolvimento em C#, colaboração com o designer das telas para garantir uma integração fluida entre a lógica de backend e a apresentação visual,\ne contribuições para a documentação abrangente do sistema. Além disso, era crucial manter-se atualizado com as diferentes áreas do projeto,\nincluindo o banco de dados e a integração deste com a camada de C#, assegurando uma sincronia eficiente entre os componentes do sistema.";


            label1.AutoSize = false;

            label1.TextAlign = ContentAlignment.MiddleLeft;
        }
    }
}
