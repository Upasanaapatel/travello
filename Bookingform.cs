using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace traveliti
{
    public partial class BookingForm : Form
    {
        // ── Fields ───────────────────────────────────────────────────────
        private int _destinationId;
        private string _destinationName;
        private decimal _price;
        private int _days;
        private string _itineraryText;
        private string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        // ── Constructor ──────────────────────────────────────────────────
        public BookingForm(int destinationId, string destinationName, decimal price, int days, string itineraryText)
        {
            _destinationId = destinationId;
            _destinationName = destinationName ?? "Unknown";
            _price = price;
            _days = days;
            _itineraryText = itineraryText ?? string.Empty;

            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape) { GoBack(); e.Handled = true; }
            };
        }

        // ── Form Load ────────────────────────────────────────────────────
        private void BookingForm_Load(object sender, EventArgs e)
        {
            // ── Populate LEFT card ───────────────────────────────────────
            lblDestinationValue.Text = _destinationName;
            lblDaysValue.Text = _days + " Day(s)";
            lblBudgetValue.Text = "₹ " + _price.ToString("N0");
            lblPerDayValue.Text = "₹ " + Math.Round(_price / (_days > 0 ? _days : 1), 0).ToString("N0") + " / day";

            // Itinerary preview
            rtbItinerary.Text = _itineraryText;

            // ── Date pickers ─────────────────────────────────────────────
            dtpTravelDate.MinDate = DateTime.Today.AddDays(1);
            dtpTravelDate.Value = DateTime.Today.AddDays(7);

            dtpReturnDate.MinDate = DateTime.Today.AddDays(2);
            dtpReturnDate.Value = DateTime.Today.AddDays(7 + _days);

            UpdateTotalCost();
        }

        // ── Recalculate total when travellers change ─────────────────────
        private void nudTravellers_ValueChanged(object sender, EventArgs e) => UpdateTotalCost();

        private void UpdateTotalCost()
        {
            decimal total = _price * (int)nudTravellers.Value;
            lblTotalCostValue.Text = "₹ " + total.ToString("N0");
        }

        // ── Auto-adjust return date when travel date changes ─────────────
        private void dtpTravelDate_ValueChanged(object sender, EventArgs e)
        {
            dtpReturnDate.MinDate = dtpTravelDate.Value.AddDays(1);
            dtpReturnDate.Value = dtpTravelDate.Value.AddDays(_days);
        }

        // ── Confirm Booking ──────────────────────────────────────────────
        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            // Validate Full Name
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter your full name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus(); return;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus(); return;
            }

            // Validate Phone
            if (string.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text.Trim().Length < 10)
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus(); return;
            }

            decimal totalCost = _price * (int)nudTravellers.Value;

            // Confirmation dialog
            var confirm = MessageBox.Show(
                $"Please confirm your booking:\n\n" +
                $"  📍 Destination  : {_destinationName}\n" +
                $"  👤 Name         : {txtFullName.Text.Trim()}\n" +
                $"  📧 Email        : {txtEmail.Text.Trim()}\n" +
                $"  📞 Phone        : {txtPhone.Text.Trim()}\n" +
                $"  🗓  Travel Date  : {dtpTravelDate.Value:dd MMM yyyy}\n" +
                $"  🔙 Return Date  : {dtpReturnDate.Value:dd MMM yyyy}\n" +
                $"  👥 Travellers   : {(int)nudTravellers.Value}\n" +
                $"  💰 Total Cost   : ₹ {totalCost:N0}\n\n" +
                $"Proceed?",
                "Confirm Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            SaveBooking(totalCost);
        }

        // ── Save to DB ───────────────────────────────────────────────────
        private void SaveBooking(decimal totalCost)
        {
            try
            {
                using (var con = new SqlConnection(conStr))
                {
                    con.Open();

                    new SqlCommand(@"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Bookings' AND xtype='U')
                        CREATE TABLE Bookings (
                            Id              INT IDENTITY(1,1) PRIMARY KEY,
                            DestinationId   INT,
                            DestinationName NVARCHAR(200),
                            FullName        NVARCHAR(200),
                            Email           NVARCHAR(200),
                            Phone           NVARCHAR(20),
                            TravelDate      DATETIME,
                            ReturnDate      DATETIME,
                            Travellers      INT,
                            Days            INT,
                            Budget          DECIMAL(18,2),
                            TotalCost       DECIMAL(18,2),
                            ItineraryText   NVARCHAR(MAX),
                            SpecialRequests NVARCHAR(MAX),
                            BookedOn        DATETIME DEFAULT GETDATE(),
                            Status          NVARCHAR(50) DEFAULT 'Confirmed'
                        )", con).ExecuteNonQuery();

                    var cmd = new SqlCommand(@"
                        INSERT INTO Bookings
                            (DestinationId, DestinationName, FullName, Email, Phone,
                             TravelDate, ReturnDate, Travellers, Days, Budget,
                             TotalCost, ItineraryText, SpecialRequests)
                        VALUES
                            (@did, @dname, @name, @email, @phone,
                             @tdate, @rdate, @travellers, @days, @budget,
                             @total, @text, @special)", con);

                    cmd.Parameters.AddWithValue("@did", _destinationId);
                    cmd.Parameters.AddWithValue("@dname", _destinationName);
                    cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@tdate", dtpTravelDate.Value);
                    cmd.Parameters.AddWithValue("@rdate", dtpReturnDate.Value);
                    cmd.Parameters.AddWithValue("@travellers", (int)nudTravellers.Value);
                    cmd.Parameters.AddWithValue("@days", _days);
                    cmd.Parameters.AddWithValue("@budget", _price);
                    cmd.Parameters.AddWithValue("@total", totalCost);
                    cmd.Parameters.AddWithValue("@text", _itineraryText);
                    cmd.Parameters.AddWithValue("@special", txtSpecial.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    $"🎉 Booking Confirmed!\n\n" +
                    $"  Name        : {txtFullName.Text.Trim()}\n" +
                    $"  Destination : {_destinationName}\n" +
                    $"  Travel Date : {dtpTravelDate.Value:dd MMM yyyy}\n" +
                    $"  Travellers  : {(int)nudTravellers.Value}\n" +
                    $"  Total Cost  : ₹ {totalCost:N0}\n\n" +
                    $"  Thank you for booking with Traveliti! ✈",
                    "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                new Popular().Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving booking:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Back ─────────────────────────────────────────────────────────
        private void btnBack_Click(object sender, EventArgs e) => GoBack();

        private void GoBack()
        {
            new GenerateItineraryForm(_destinationId, _destinationName, string.Empty, _price).Show();
            this.Close();
        }
    }
}