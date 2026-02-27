using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace traveliti
{
    public partial class DashboardUC : Form
    {
        public DashboardUC()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            MainHomePage next = new MainHomePage();
            next.Show();
            this.Hide();
        }
    }
}
