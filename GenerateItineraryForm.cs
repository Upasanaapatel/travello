using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace traveliti
{
    public partial class GenerateItineraryForm : Form
    {
        // ── Fields ───────────────────────────────────────────────────────
        private int _destinationId;
        private string _name;
        private string _description;
        private decimal _price;
        private string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        // ── Constructor ──────────────────────────────────────────────────
        public GenerateItineraryForm(int destinationId, string name, string description, decimal price)
        {
            _destinationId = destinationId;
            _name = name ?? "Unknown Destination";
            _description = description ?? string.Empty;
            _price = price;

            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape) { GoBack(); e.Handled = true; }
            };
        }

        // ── Form Load ────────────────────────────────────────────────────
        private void GenerateItineraryForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "✈   Generate Itinerary";
            lblSubtitle.Text = "Destination: " + _name + "   |   Budget: ₹ " + _price.ToString("N0");

            chkSightseeing.Checked = true;
            chkFoodTour.Checked = true;

            btnSave.Enabled = false;
            btnBook.Enabled = false;
        }

        // ── Generate Button ──────────────────────────────────────────────
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var activities = new List<string>();
            if (chkSightseeing.Checked) activities.Add("Sightseeing");
            if (chkAdventure.Checked) activities.Add("Adventure Sports");
            if (chkFoodTour.Checked) activities.Add("Food Tour");
            if (chkShopping.Checked) activities.Add("Shopping");
            if (chkCultural.Checked) activities.Add("Cultural Events");
            if (chkNature.Checked) activities.Add("Nature Walks");
            if (chkBeach.Checked) activities.Add("Beach / Lake");
            if (chkNightlife.Checked) activities.Add("Nightlife");
            if (chkSpa.Checked) activities.Add("Spa & Wellness");
            if (chkPhotography.Checked) activities.Add("Photography Spots");

            if (activities.Count == 0)
            {
                MessageBox.Show("Please select at least one activity.",
                    "No Activity Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int days = (int)nudDays.Value;
            string itinerary = BuildItinerary(days, activities);

            rtbItinerary.Text = itinerary;
            rtbItinerary.Visible = true;
            lblItineraryOutput.Visible = true;
            btnSave.Enabled = true;
            btnBook.Enabled = true;

            ExportItineraryToTxt(itinerary);
            panelCenter.ScrollControlIntoView(rtbItinerary);
        }

        // ── Itinerary Builder ────────────────────────────────────────────
        private string BuildItinerary(int days, List<string> activities)
        {
            var sb = new StringBuilder();

            sb.AppendLine("╔══════════════════════════════════════════════════════════════╗");
            sb.AppendLine("   TRAVEL ITINERARY: " + _name.ToUpper());
            sb.AppendLine("   Duration  : " + days + " Day(s)");
            sb.AppendLine("   Budget    : ₹ " + _price.ToString("N0"));
            sb.AppendLine("   Activities: " + string.Join(", ", activities));
            sb.AppendLine("╚══════════════════════════════════════════════════════════════╝");
            sb.AppendLine();

            if (!string.IsNullOrWhiteSpace(_description))
            {
                sb.AppendLine("About " + _name + ":");
                sb.AppendLine(_description);
                sb.AppendLine();
            }

            int idx = 0;
            for (int day = 1; day <= days; day++)
            {
                sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                sb.AppendLine("  DAY " + day +
                    (day == 1 ? " – Arrival & Exploration" :
                     day == days ? " – Leisure & Departure" :
                                   " – Full Day Experience"));
                sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                sb.AppendLine();
                sb.AppendLine("  🌅 MORNING");
                sb.AppendLine("     " + GetDesc("Morning", activities[idx++ % activities.Count]));
                sb.AppendLine();
                sb.AppendLine("  ☀  AFTERNOON");
                sb.AppendLine("     " + GetDesc("Afternoon", activities[idx++ % activities.Count]));
                sb.AppendLine();
                sb.AppendLine("  🌆 EVENING");
                sb.AppendLine("     " + GetDesc("Evening", activities[idx++ % activities.Count]));
                sb.AppendLine();
                sb.AppendLine("  💰 Estimated Daily Budget: ₹ " + Math.Round(_price / days, 0).ToString("N0"));
                sb.AppendLine();
            }

            sb.AppendLine("══════════════════════════════════════════════════════════════");
            sb.AppendLine("  TRIP SUMMARY");
            sb.AppendLine("  Total Days   : " + days);
            sb.AppendLine("  Total Budget : ₹ " + _price.ToString("N0"));
            sb.AppendLine("  Activities   : " + string.Join(", ", activities));
            sb.AppendLine("  Generated on : " + DateTime.Now.ToString("dd MMM yyyy, hh:mm tt"));
            sb.AppendLine("══════════════════════════════════════════════════════════════");

            return sb.ToString();
        }

        private string GetDesc(string slot, string activity)
        {
            var t = new Dictionary<string, string[]>
            {
                { "Sightseeing",       new[] { "Explore the famous landmarks and monuments of " + _name + ".",
                                               "Visit the top-rated tourist spots and viewpoints.",
                                               "Enjoy a guided sightseeing tour around " + _name + "." } },
                { "Adventure Sports",  new[] { "Get your adrenaline pumping with local adventure sports.",
                                               "Try trekking, zip-lining, or water rafting near " + _name + ".",
                                               "Join an adventure sports package recommended by locals." } },
                { "Food Tour",         new[] { "Taste authentic local cuisine at popular eateries in " + _name + ".",
                                               "Visit the local food market and sample street food specialties.",
                                               "Enjoy a food-walk through " + _name + "'s best restaurants." } },
                { "Shopping",          new[] { "Browse local markets and pick up souvenirs from " + _name + ".",
                                               "Visit shopping malls and handicraft stores.",
                                               "Explore the local bazaar for unique items." } },
                { "Cultural Events",   new[] { "Attend a cultural performance or local festival in " + _name + ".",
                                               "Visit museums and heritage galleries.",
                                               "Watch traditional dance and music performances." } },
                { "Nature Walks",      new[] { "Take a refreshing nature walk through " + _name + "'s scenic trails.",
                                               "Explore nearby forests, parks, or botanical gardens.",
                                               "Bird-watching or sunrise hike in the natural surroundings." } },
                { "Beach / Lake",      new[] { "Relax by the beach/lake and enjoy the natural beauty.",
                                               "Try water sports or a peaceful boat ride.",
                                               "Watch the sunset at the waterfront of " + _name + "." } },
                { "Nightlife",         new[] { "Experience the vibrant nightlife scene of " + _name + ".",
                                               "Visit rooftop bars or local pubs for a relaxed evening.",
                                               "Enjoy live music and entertainment at popular venues." } },
                { "Spa & Wellness",    new[] { "Rejuvenate with a traditional spa treatment.",
                                               "Book a wellness session at a top-rated spa in " + _name + ".",
                                               "Enjoy yoga or meditation by a scenic spot." } },
                { "Photography Spots", new[] { "Capture stunning shots at " + _name + "'s iconic photo spots.",
                                               "Visit sunrise/sunset points for breathtaking photographs.",
                                               "Explore hidden gems and scenic viewpoints for photography." } },
            };

            if (t.ContainsKey(activity))
            {
                var opts = t[activity];
                return opts[(slot == "Morning" ? 0 : slot == "Afternoon" ? 1 : 2) % opts.Length];
            }
            return "Enjoy " + activity + " at " + _name + ".";
        }

        // ── Export to TXT ────────────────────────────────────────────────
        private void ExportItineraryToTxt(string text)
        {
            try
            {
                string safe = string.Concat(_name.Split(Path.GetInvalidFileNameChars()));
                string folder = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "Traveliti Itineraries");
                Directory.CreateDirectory(folder);
                string path = Path.Combine(folder, $"Itinerary_{safe}_{DateTime.Now:yyyyMMdd_HHmmss}.txt");
                File.WriteAllText(path, text, Encoding.UTF8);
                MessageBox.Show($"Itinerary exported!\n\n📄 {path}",
                    "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not export:\n" + ex.Message,
                    "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ── Save Button ──────────────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbItinerary.Text))
            { MessageBox.Show("Generate an itinerary first."); return; }

            try
            {
                using (var con = new SqlConnection(conStr))
                {
                    con.Open();
                    new SqlCommand(@"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='SavedItineraries' AND xtype='U')
                        CREATE TABLE SavedItineraries (Id INT IDENTITY(1,1) PRIMARY KEY,
                        DestinationId INT, DestinationName NVARCHAR(200), Days INT,
                        Budget DECIMAL(18,2), ItineraryText NVARCHAR(MAX), CreatedOn DATETIME DEFAULT GETDATE())", con)
                        .ExecuteNonQuery();

                    var cmd = new SqlCommand(@"INSERT INTO SavedItineraries
                        (DestinationId,DestinationName,Days,Budget,ItineraryText)
                        VALUES(@did,@dname,@days,@budget,@text)", con);
                    cmd.Parameters.AddWithValue("@did", _destinationId);
                    cmd.Parameters.AddWithValue("@dname", _name);
                    cmd.Parameters.AddWithValue("@days", (int)nudDays.Value);
                    cmd.Parameters.AddWithValue("@budget", _price);
                    cmd.Parameters.AddWithValue("@text", rtbItinerary.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Itinerary saved! ✅", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            { MessageBox.Show("Error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // ── Book Now Button ──────────────────────────────────────────────
        private void btnBook_Click(object sender, EventArgs e)
        {
            BookingForm booking = new BookingForm(
        _destinationId,       // destination ID
        _name,                // destination name e.g. "Varanasi"
        _price,               // budget e.g. 25000
        (int)nudDays.Value,   // number of days
        rtbItinerary.Text     // full itinerary text
    );
            booking.Show();
            this.Hide();


        }
        private void btnBack_Click(object sender, EventArgs e) => GoBack();

        private void GoBack()
        {
            new DestinationDetail(_destinationId).Show();
            this.Close();
        }
    }
}