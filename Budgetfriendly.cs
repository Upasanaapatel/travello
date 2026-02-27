using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace traveliti
{
    public partial class Budgetfriendly : Form
    {
        public Budgetfriendly()
        {
            InitializeComponent();
        }

        // ── Collect selected RadioButton values ──────────────────────────
        private string GetSelected(params RadioButton[] radios)
        {
            foreach (var rb in radios)
                if (rb.Checked)
                    // Strip leading emoji + spaces for clean text
                    return rb.Text.Length > 4 ? rb.Text.Substring(rb.Text.IndexOf(' ') + 1).Trim() : rb.Text.Trim();
            return "Not selected";
        }

        private UserPreference GetUserPreferences()
        {
            // For backward compatibility with code that expects List<string>,
            // wrap single selected value in a list
            return new UserPreference
            {
                Transport = new List<string> { GetSelected(rbBus, rbCab, rbTrain, rbBike, rbFlight) },
                Accommodation = new List<string> { GetSelected(rbHotel, rbHomestay, rbResort, rbCamp, rbApartment, rbNoStay) },
                TripPurpose = new List<string> { GetSelected(rbVacation, rbEducation, rbBusiness, rbMedical, rbFestival) },
                Budget = new List<string> { GetSelected(rbUnder1000, rb1000_3000, rb3000_5000, rb5000_10000, rbLuxury, rbFree, rbStudent, rbFamily) }
            };
        }
      

        // ── Load saved preferences ───────────────────────────────────────
        private void Budgetfriendly_Load(object sender, EventArgs e)
        {
            try
            {
                if (UserSession.UserId == 0)
                {
                    MessageBox.Show("User session not found. Please login again.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(
                    @"Data Source=localhost\SQLEXPRESS;Initial Catalog=traveliti;Integrated Security=True"))
                {
                    string query = @"SELECT TOP 1 * FROM UserPreferences
                                     WHERE UserId = @uid ORDER BY Id DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@uid", UserSession.UserId);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        RestoreRadio(dr["Transport"]?.ToString(),
                            rbBus, rbCab, rbTrain, rbBike, rbFlight);
                        RestoreRadio(dr["Accommodation"]?.ToString(),
                            rbHotel, rbHomestay, rbResort, rbCamp, rbApartment, rbNoStay);
                        RestoreRadio(dr["TripPurpose"]?.ToString(),
                            rbVacation, rbEducation, rbBusiness, rbMedical, rbFestival);
                        RestoreRadio(dr["Budget"]?.ToString(),
                            rbUnder1000, rb1000_3000, rb3000_5000, rb5000_10000,
                            rbLuxury, rbFree, rbStudent, rbFamily);
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading preferences:\n" + ex.Message);
            }
        }

        /// <summary>Checks the RadioButton whose text contains the saved value.</summary>
        private void RestoreRadio(string savedData, params RadioButton[] radios)
        {
            if (string.IsNullOrEmpty(savedData)) return;
            foreach (var rb in radios)
            {
                string clean = rb.Text.Length > 4
                    ? rb.Text.Substring(rb.Text.IndexOf(' ') + 1).Trim()
                    : rb.Text.Trim();
                if (savedData.Contains(clean))
                {
                    rb.Checked = true;
                    return;   // only one can be selected
                }
            }
        }

        // ── Submit — show result in the result panel ─────────────────────
        private void submitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                UserPreference pref = GetUserPreferences();

                // Build summary text
                string summary =
                    $"🚗  Transport       :  {pref.Transport[0]}\r\n" +
                    $"🏨  Accommodation  :  {pref.Accommodation[0]}\r\n" +
                    $"🎯  Trip Purpose    :  {pref.TripPurpose[0]}\r\n" +
                    $"💰  Budget          :  {pref.Budget[0]}";

                lblResultDetail.Text = summary;
                lblResultTitle.Text = "📋  Your Selection Summary";

                // Show the result panel
                pnlResultArea.Visible = true;
                lblResult.Visible = false;

                // Scroll to result
                mainScroll.ScrollControlIntoView(resultCard);

                // Open review form
                ReviewForm review = new ReviewForm(pref);
                review.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ── Back button (button4 wired to this) ─────────────────────────
        private void backbutton_Click(object sender, EventArgs e)
        {
            MainHomePage next = new MainHomePage();
            next.Show();
            this.Hide();
        }

        // ── Stub event handlers (kept for designer compat) ───────────────
        private void chkUnder1000_CheckedChanged(object sender, EventArgs e) { }
        private void chk1000_3000_CheckedChanged(object sender, EventArgs e) { }
        private void chk3000_5000_CheckedChanged(object sender, EventArgs e) { }
        private void chk5000_10000_CheckedChanged(object sender, EventArgs e) { }
        private void chkLuxury_CheckedChanged(object sender, EventArgs e) { }
        private void chkFamily_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox20_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox9_CheckedChanged(object sender, EventArgs e) { }
        private void Budgetfriendly_Resize(object sender, EventArgs e) { }
    }
}