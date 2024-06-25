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


        private void ll_gitAnder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/AndersonRocha331");
        }

        private void ll_rafaLinkd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.linkedin.com/in/rafael-moraes-22621320a/");
        }

        private void ll_gitRafa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/RAFAELDM22");
        }

        private void ll_victorLinked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.linkedin.com/in/victurs/");
        }

        private void ll_gitVictor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/victurs");
        }

        private void ll_vinyLinked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.linkedin.com/in/vinicius-cruz-ba2502288/");
        }

        private void ll_gitViny_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/ViniciusCruzSP");
        }

        private void ll_wallaceLinked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.linkedin.com/in/wallace-batista-375205281/");
        }

        private void ll_gitWallace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/wollihenrique");
        }

        private void ll_yasminLinked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.linkedin.com/in/yasminnasc/");
        }

        private void ll_gitYasmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/yasminnst");
        }

        private void ll_anderLinked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.linkedin.com/in/anderson-rocha-de-souza-939309315");
        }

    }
}