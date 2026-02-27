using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml.Linq;

namespace traveliti
{
    public partial class Contact : UserControl
    {
        public Contact()
        {
            InitializeComponent();

        }

        // ── FORM LOAD ────────────────────────────────────────────────────
        private void Contact_Load(object sender, EventArgs e)
        {

        }

        // ── ESC → back to MainHomePage ────────────────────────────────────
        private void Contact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GoBack();
                e.Handled = true;
            }
        }


        private void CardPanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // White rounded card
            var rect = new Rectangle(0, 0, cardPanel.Width - 1, cardPanel.Height - 1);
            using var path = RoundedRect(rect, 14);
            using var fill = new SolidBrush(Color.White);
            g.FillPath(fill, path);
            using var border = new Pen(Color.FromArgb(218, 224, 235), 1.5f);
            g.DrawPath(border, path);
            cardPanel.Region = new Region(path);
        }

        private void InfoCard_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, infoCard.Width - 1, infoCard.Height - 1);
            using var path = RoundedRect(rect, 14);
            using var fill = new SolidBrush(Color.White);
            g.FillPath(fill, path);
            using var border = new Pen(Color.FromArgb(218, 224, 235), 1.5f);
            g.DrawPath(border, path);
            infoCard.Region = new Region(path);

            // Blue gradient header
            using var grad = new LinearGradientBrush(
                new Rectangle(0, 0, infoCard.Width, 58),
                Color.FromArgb(41, 98, 255),
                Color.FromArgb(0, 160, 210),
                LinearGradientMode.Horizontal);
            using var top = RoundedRectTop(new Rectangle(0, 0, infoCard.Width, 58), 14);
            g.FillPath(grad, top);
        }

        // ════════════════════════════════════════════════════════════════
        //  SEND BUTTON
        // ════════════════════════════════════════════════════════════════
        private void btnSend_Click(object sender, EventArgs e)
        {
            // ── Validation ────────────────────────────────────────────────
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                ShowStatus("⚠️  Please enter your full name.", Color.FromArgb(200, 60, 60));
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                ShowStatus("⚠️  Please enter a valid email address.", Color.FromArgb(200, 60, 60));
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                ShowStatus("⚠️  Please write a message before sending.", Color.FromArgb(200, 60, 60));
                txtMessage.Focus();
                return;
            }

            // ── Simulate sending (replace with real email/DB logic) ───────
            try
            {
                // ── Option A: Open default email client with pre-filled fields ──
                string to = "support@traveliti.com";
                string subject = Uri.EscapeDataString(txtSubject.Text.Trim() == "" ? "Enquiry from Travel Itinerary App" : txtSubject.Text.Trim());
                string body = Uri.EscapeDataString(
                    $"Name: {txtName.Text.Trim()}\n" +
                    $"Phone: {txtPhone.Text.Trim()}\n\n" +
                    txtMessage.Text.Trim());

                Process.Start(new ProcessStartInfo
                {
                    FileName = $"mailto:{to}?subject={subject}&body={body}",
                    UseShellExecute = true
                });

                ShowStatus("✅  Message sent successfully! We'll respond within 24 hours.", Color.FromArgb(0, 150, 80));
                ClearFields();
            }
            catch (Exception ex)
            {
                ShowStatus("❌  Could not open email client: " + ex.Message, Color.FromArgb(200, 60, 60));
            }
        }

        // ════════════════════════════════════════════════════════════════
        //  CLEAR BUTTON
        // ════════════════════════════════════════════════════════════════
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            ShowStatus("🗑  Form cleared.", Color.FromArgb(120, 130, 155));
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtSubject.Clear();
            txtMessage.Clear();
            txtName.Focus();
        }

        // ════════════════════════════════════════════════════════════════
        //  BACK BUTTON
        // ════════════════════════════════════════════════════════════════
        private void btnBack_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            MainHomePage home = new MainHomePage();
            home.Show();
            this.Hide();
        }

        // ════════════════════════════════════════════════════════════════
        //  SOCIAL LINK BUTTONS
        // ════════════════════════════════════════════════════════════════
        private void btnFacebook_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.facebook.com/traveliti");   // ← replace with your page URL
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.instagram.com/traveliti");  // ← replace with your page URL
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.twitter.com/traveliti");    // ← replace with your page URL
        }

        private void btnWhatsApp_Click(object sender, EventArgs e)
        {
            // Opens WhatsApp chat with your number (replace 919876543210 with your number)
            OpenUrl("https://wa.me/919876543210");
        }

        // ── Click on email label → open mailto ───────────────────────────
        private void lblEmailVal_Click(object sender, EventArgs e)
        {
            OpenUrl("mailto:support@traveliti.com");
        }

        // ════════════════════════════════════════════════════════════════
        //  HELPERS
        // ════════════════════════════════════════════════════════════════
        private void ShowStatus(string message, Color color)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = color;
        }

        private static void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open link:\n" + ex.Message);
            }
        }

        private static GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            int d = radius * 2;
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        private static GraphicsPath RoundedRectTop(Rectangle r, int radius)
        {
            int d = radius * 2;
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddLine(r.Right, r.Bottom, r.X, r.Bottom);
            p.CloseFigure();
            return p;
        }

        private void lblSubject_Click(object sender, EventArgs e)
        {

        }
    }
}