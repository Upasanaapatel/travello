using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace traveliti
{
    public partial class HauntedPlaceForm : Form
    {
        private string GetSelectedDestination()
        {
            if (rbPlace9.Checked) return "Haunted Palace";
            if (rbPlace2.Checked) return "Dark Castle";
            if (rbPlace3.Checked) return "Ghost Forest";
            if (rbPlace4.Checked) return "Abandoned Mansion";
            if (rbPlace5.Checked) return "Old Graveyard";
            if (rbPlace6.Checked) return "Haunted Bridge";
            if (rbPlace7.Checked) return "Mystery House";
            if (rbPlace8.Checked) return "Shadow Fort";

            return null;
        }
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        // Store all locations in dictionary
        Dictionary<Button, string> buttonLocations = new Dictionary<Button, string>();

        public HauntedPlaceForm()
        {
            InitializeComponent();
        }
        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selected = sender as RadioButton;

            if (selected != null && selected.Checked)
            {
                UncheckAllRadioButtons(this, selected);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                OffBeat hid = new OffBeat();
                hid.Show();
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void UncheckAllRadioButtons(Control parent, RadioButton selected)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is RadioButton rb && rb != selected)
                {
                    rb.Checked = false;
                }

                // Recursive call (this is the important fix)
                if (c.HasChildren)
                {
                    UncheckAllRadioButtons(c, selected);
                }
            }
        }


        private void HauntedPlaceForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            LoadHauntedPlaces();
        }
        

        // 🔥 LOAD ALL 8 PLACES
        private void LoadHauntedPlaces()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "SELECT TOP 8 * FROM HauntedPlaces";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int index = 0;

                while (reader.Read())
                {
                    string location = reader["Location"].ToString();

                    // Get button dynamically
                    Button btn = this.Controls.Find("btn_view" + (index + 1), true)[0] as Button;

                    if (btn != null)
                    {
                        buttonLocations[btn] = location;
                        btn.Click -= btn_view1_Click;
                        btn.Click += btn_view1_Click;
                    }

                    index++;
                }
            }
        }

        // 🌍 COMMON CLICK FOR ALL 8 BUTTONS
        private void btn_view1_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null && buttonLocations.ContainsKey(clickedButton))
            {
                string location = buttonLocations[clickedButton];

                if (!string.IsNullOrEmpty(location))
                {
                    string url = "https://www.google.com/maps/search/?api=1&query="
                                 + Uri.EscapeDataString(location);

                    Process.Start(new ProcessStartInfo(url)
                    {
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("Location not available!");
                }
            }

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            OffBeat hid = new OffBeat();
            hid.Show();
            this.Close();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // keep this empty (no problem)
        }

        private void toppanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
        }


        private void HauntedPlaceForm_Resize(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

       

        private void rbPlace2_CheckedChanged(object sender, EventArgs e)
        {


        }
    }
}