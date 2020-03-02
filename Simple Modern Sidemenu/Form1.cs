using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_Modern_Sidemenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(panel1);
            bunifuFormDock1.SubscribeControlToDragEvents(panel2);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage("Dashboard");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage("Activity");
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage("Project");
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage("Inbox");
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage("Contact");
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage("About");
        }
    }
}
