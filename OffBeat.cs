using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace traveliti
{
    public partial class OffBeat : Form
    {
        public OffBeat()
        {
            InitializeComponent();
            this.KeyPreview = true;   // form receives keys before controls
        }

        private void HiddenGems_Load(object sender, EventArgs e)
        {
        }

        private void HiddenGems_KeyDown(object sender, KeyEventArgs e)
        {
            // ESC → go to MainHomePage
            if (e.KeyCode == Keys.Escape)
            {
                MainHomePage home = new MainHomePage();
                home.Show();
                this.Hide();
                e.Handled = true;
            }

            // F2 → go to MainHomePage (unchanged)
            if (e.KeyCode == Keys.F2)
            {
                MainHomePage home = new MainHomePage();
                home.Show();
                this.Close();
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            MainHomePage home = new MainHomePage();
            home.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void hauntedplace_Click(object sender, EventArgs e)
        {
            HauntedPlaceForm bhh = new HauntedPlaceForm();
            bhh.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Wonder_Click(object sender, EventArgs e)
        {
            Wonder won= new Wonder();
            won.Show();
            this.Hide();
        }
    }
}