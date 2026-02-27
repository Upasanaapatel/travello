namespace traveliti
{
    partial class Budgetfriendly
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── TOP PANEL (UNCHANGED) ────────────────────────────────────
            toppanel = new Panel();
            labelTagline = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();

            // ── RIGHT PANEL (UNCHANGED STYLE) ────────────────────────────
            panel2 = new Panel();
            button3 = new Button();
            button4 = new Button();

            // ── MAIN SCROLL CONTAINER ─────────────────────────────────────
            mainScroll = new Panel();
            innerPanel = new Panel();

            // ── SECTION CARDS ─────────────────────────────────────────────
            cardTransport = new Panel();
            cardAccommodation = new Panel();
            cardPurpose = new Panel();
            cardBudget = new Panel();
            resultCard = new Panel();
            pnlResultArea = new Panel();

            // RadioButtons — Transport
            rbBus = new RadioButton();
            rbCab = new RadioButton();
            rbTrain = new RadioButton();
            rbBike = new RadioButton();
            rbFlight = new RadioButton();

            // RadioButtons — Accommodation
            rbHotel = new RadioButton();
            rbHomestay = new RadioButton();
            rbResort = new RadioButton();
            rbCamp = new RadioButton();
            rbApartment = new RadioButton();
            rbNoStay = new RadioButton();

            // RadioButtons — Purpose
            rbVacation = new RadioButton();
            rbEducation = new RadioButton();
            rbBusiness = new RadioButton();
            rbMedical = new RadioButton();
            rbFestival = new RadioButton();

            // RadioButtons — Budget
            rbUnder1000 = new RadioButton();
            rb1000_3000 = new RadioButton();
            rb3000_5000 = new RadioButton();
            rb5000_10000 = new RadioButton();
            rbLuxury = new RadioButton();
            rbFree = new RadioButton();
            rbStudent = new RadioButton();
            rbFamily = new RadioButton();

            // Result + Submit
            lblResultTitle = new Label();
            lblResultDetail = new Label();
            submitbutton = new Button();
            lblResult = new Label();

            // Legacy hidden controls
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel3 = new Panel();
            genitibtn = new Button();
            backbutton = new Button();
            label1 = new Label(); label2 = new Label();
            label5 = new Label(); label6 = new Label();
            chkBus = new CheckBox(); chkCab = new CheckBox();
            chkTrain = new CheckBox(); chkBike = new CheckBox();
            chkFlight = new CheckBox();
            chkHotel = new CheckBox(); chkHomestay = new CheckBox();
            chkResort = new CheckBox(); chkCamp = new CheckBox();
            chkApartment = new CheckBox(); chkNoStay = new CheckBox();
            chkVacation = new CheckBox(); chkEducation = new CheckBox();
            chkBusiness = new CheckBox(); chkMedical = new CheckBox();
            chkFestival = new CheckBox();
            chkUnder1000 = new CheckBox(); chk1000_3000 = new CheckBox();
            chk3000_5000 = new CheckBox(); chk5000_10000 = new CheckBox();
            chkLuxury = new CheckBox(); chkFree = new CheckBox();
            chkStudent = new CheckBox(); chkFamily = new CheckBox();

            // ── SUSPEND ──────────────────────────────────────────────────
            toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            mainScroll.SuspendLayout();
            innerPanel.SuspendLayout();
            cardTransport.SuspendLayout();
            cardAccommodation.SuspendLayout();
            cardPurpose.SuspendLayout();
            cardBudget.SuspendLayout();
            pnlResultArea.SuspendLayout();
            resultCard.SuspendLayout();
            SuspendLayout();

            // ════════════════════════════════════════════════════════════
            //  TOP PANEL  (UNCHANGED)
            // ════════════════════════════════════════════════════════════
            toppanel.BackColor = Color.White;
            toppanel.BorderStyle = BorderStyle.Fixed3D;
            toppanel.Controls.Add(labelTagline);
            toppanel.Controls.Add(label3);
            toppanel.Controls.Add(label4);
            toppanel.Controls.Add(pictureBox1);
            toppanel.Dock = DockStyle.Top;
            toppanel.ImeMode = ImeMode.Katakana;
            toppanel.Location = new Point(0, 0);
            toppanel.Name = "toppanel";
            toppanel.Size = new Size(1370, 69);
            toppanel.TabIndex = 6;
            toppanel.UseWaitCursor = true;

            labelTagline.AutoSize = true;
            labelTagline.ForeColor = Color.Navy;
            labelTagline.Location = new Point(144, 36);
            labelTagline.Name = "labelTagline";
            labelTagline.TabIndex = 4;
            labelTagline.Text = "Your Perfect Escape Awaits";

            label3.AutoSize = true;
            label3.Location = new Point(100, 36);
            label3.Name = "label3";
            label3.TabIndex = 3;

            label4.AccessibleRole = AccessibleRole.MenuBar;
            label4.AllowDrop = true;
            label4.AutoEllipsis = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(110, 0);
            label4.Name = "label4";
            label4.Size = new Size(304, 36);
            label4.TabIndex = 2;
            label4.Text = "Travel Itinerary";

            pictureBox1.Image = Properties.Resources.travel;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;

            // ════════════════════════════════════════════════════════════
            //  RIGHT PANEL  (UNCHANGED)
            // ════════════════════════════════════════════════════════════
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1257, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(113, 680);
            panel2.TabIndex = 22;

            button3.BackColor = Color.Blue;
            button3.Dock = DockStyle.Bottom;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 579);
            button3.Name = "button3";
            button3.Size = new Size(109, 58);
            button3.TabIndex = 22;
            button3.Text = "Generate Itinerary";
            button3.UseVisualStyleBackColor = false;

            button4.BackColor = Color.Red;
            button4.Dock = DockStyle.Bottom;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(0, 637);
            button4.Name = "button4";
            button4.Size = new Size(109, 39);
            button4.TabIndex = 6;
            button4.Text = "🔁 Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += backbutton_Click;

            // ════════════════════════════════════════════════════════════
            //  MAIN SCROLL
            // ════════════════════════════════════════════════════════════
            mainScroll.AutoScroll = true;
            mainScroll.BackColor = Color.FromArgb(240, 244, 248);
            mainScroll.Dock = DockStyle.Fill;
            mainScroll.Location = new Point(0, 69);
            mainScroll.Name = "mainScroll";
            mainScroll.Padding = new Padding(20, 16, 20, 16);
            mainScroll.TabIndex = 30;
            mainScroll.Controls.Add(innerPanel);

            innerPanel.BackColor = Color.Transparent;
            innerPanel.Location = new Point(20, 16);
            innerPanel.Name = "innerPanel";
            innerPanel.Size = new Size(1210, 800);
            innerPanel.TabIndex = 0;
            innerPanel.Controls.Add(cardTransport);
            innerPanel.Controls.Add(cardAccommodation);
            innerPanel.Controls.Add(cardPurpose);
            innerPanel.Controls.Add(cardBudget);
            innerPanel.Controls.Add(resultCard);

            // ════════════════════════════════════════════════════════════
            //  CARD: TRANSPORT  (top-left)
            // ════════════════════════════════════════════════════════════
            BuildCard(cardTransport, new Point(0, 0), new Size(590, 265),
                      "🚗  Transport Preferences", Color.FromArgb(41, 98, 255));
            AddRadioButtons(cardTransport,
                new[] { rbBus, rbCab, rbTrain, rbBike, rbFlight },
                new[] { "🚌  Bus", "🚕  Cab / Taxi", "🚆  Train",
                        "🏍  Bike Rental", "✈️  Flight" }, 2);
            rbBus.Name = "rbBus"; rbCab.Name = "rbCab";
            rbTrain.Name = "rbTrain"; rbBike.Name = "rbBike"; rbFlight.Name = "rbFlight";

            // ════════════════════════════════════════════════════════════
            //  CARD: ACCOMMODATION  (top-right)
            // ════════════════════════════════════════════════════════════
            BuildCard(cardAccommodation, new Point(610, 0), new Size(590, 265),
                      "🏨  Accommodation Type", Color.FromArgb(0, 160, 130));
            AddRadioButtons(cardAccommodation,
                new[] { rbHotel, rbHomestay, rbResort, rbCamp, rbApartment, rbNoStay },
                new[] { "🏩  Hotel", "🏡  Homestay", "🌴  Resort",
                        "⛺  Camps / Tents", "🏢  Apartment", "🚶  No Stay Needed" }, 2);
            rbHotel.Name = "rbHotel"; rbHomestay.Name = "rbHomestay";
            rbResort.Name = "rbResort"; rbCamp.Name = "rbCamp";
            rbApartment.Name = "rbApartment"; rbNoStay.Name = "rbNoStay";

            // ════════════════════════════════════════════════════════════
            //  CARD: PURPOSE  (bottom-left)
            // ════════════════════════════════════════════════════════════
            BuildCard(cardPurpose, new Point(0, 285), new Size(590, 255),
                      "🎯  Trip Purpose", Color.FromArgb(180, 80, 200));
            AddRadioButtons(cardPurpose,
                new[] { rbVacation, rbEducation, rbBusiness, rbMedical, rbFestival },
                new[] { "🌅  Vacation / Holiday", "📚  Education / Study",
                        "💼  Business", "🏥  Medical Travel", "🎉  Festival / Event" }, 2);
            rbVacation.Name = "rbVacation"; rbEducation.Name = "rbEducation";
            rbBusiness.Name = "rbBusiness"; rbMedical.Name = "rbMedical";
            rbFestival.Name = "rbFestival";

            // ════════════════════════════════════════════════════════════
            //  CARD: BUDGET  (bottom-right)
            // ════════════════════════════════════════════════════════════
            BuildCard(cardBudget, new Point(610, 285), new Size(590, 255),
                      "💰  Budget Friendly", Color.FromArgb(220, 140, 0));
            AddRadioButtons(cardBudget,
                new[] { rbUnder1000, rb1000_3000, rb3000_5000, rb5000_10000,
                        rbLuxury, rbFree, rbStudent, rbFamily },
                new[] { "💵  Under ₹1,000 / day", "💵  ₹1,000 – ₹3,000 / day",
                        "💵  ₹3,000 – ₹5,000 / day", "💵  ₹5,000 – ₹10,000 / day",
                        "👑  Luxury (₹10,000+)", "🆓  Free Attractions",
                        "🎓  Student Budget", "👨‍👩‍👧  Family Budget" }, 2);
            rbUnder1000.Name = "rbUnder1000"; rb1000_3000.Name = "rb1000_3000";
            rb3000_5000.Name = "rb3000_5000"; rb5000_10000.Name = "rb5000_10000";
            rbLuxury.Name = "rbLuxury"; rbFree.Name = "rbFree";
            rbStudent.Name = "rbStudent"; rbFamily.Name = "rbFamily";

            // ════════════════════════════════════════════════════════════
            //  RESULT CARD  (full width, below 4 cards)
            // ════════════════════════════════════════════════════════════
            resultCard.BackColor = Color.White;
            resultCard.Location = new Point(0, 558);
            resultCard.Name = "resultCard";
            resultCard.Size = new Size(1200, 180);
            resultCard.TabIndex = 50;
            resultCard.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using var path = RoundedRect(new Rectangle(0, 0, resultCard.Width - 1, resultCard.Height - 1), 12);
                using var brush = new System.Drawing.SolidBrush(Color.White);
                g.FillPath(brush, path);
                using var pen = new Pen(Color.FromArgb(218, 224, 235), 1.5f);
                g.DrawPath(pen, path);
                resultCard.Region = new Region(path);
            };
            resultCard.Controls.Add(submitbutton);
            resultCard.Controls.Add(pnlResultArea);
            resultCard.Controls.Add(lblResult);

            // Submit button
            submitbutton.BackColor = Color.FromArgb(41, 98, 255);
            submitbutton.FlatAppearance.BorderSize = 0;
            submitbutton.FlatStyle = FlatStyle.Flat;
            submitbutton.Cursor = Cursors.Hand;
            submitbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            submitbutton.ForeColor = Color.White;
            submitbutton.Location = new Point(20, 20);
            submitbutton.Name = "submitbutton";
            submitbutton.Size = new Size(130, 46);
            submitbutton.TabIndex = 1;
            submitbutton.Text = "✔  Submit";
            submitbutton.UseVisualStyleBackColor = false;
            submitbutton.Click += submitbutton_Click;

            // lblResult (small static label)
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblResult.ForeColor = Color.FromArgb(140, 150, 175);
            lblResult.Location = new Point(20, 76);
            lblResult.Name = "lblResult";
            lblResult.Text = "Your Recommended Result:";
            lblResult.TabIndex = 2;

            // Result detail panel — hidden until Submit clicked
            pnlResultArea.BackColor = Color.FromArgb(245, 248, 255);
            pnlResultArea.Location = new Point(170, 10);
            pnlResultArea.Name = "pnlResultArea";
            pnlResultArea.Size = new Size(1010, 158);
            pnlResultArea.TabIndex = 3;
            pnlResultArea.Visible = false;
            pnlResultArea.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using var path = RoundedRect(new Rectangle(0, 0, pnlResultArea.Width - 1, pnlResultArea.Height - 1), 10);
                using var fill = new System.Drawing.SolidBrush(Color.FromArgb(245, 248, 255));
                g.FillPath(fill, path);
                using var pen = new Pen(Color.FromArgb(190, 210, 255), 1.5f);
                g.DrawPath(pen, path);
                pnlResultArea.Region = new Region(path);
            };
            pnlResultArea.Controls.Add(lblResultTitle);
            pnlResultArea.Controls.Add(lblResultDetail);

            lblResultTitle.AutoSize = false;
            lblResultTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResultTitle.ForeColor = Color.FromArgb(41, 98, 255);
            lblResultTitle.Location = new Point(14, 10);
            lblResultTitle.Name = "lblResultTitle";
            lblResultTitle.Size = new Size(980, 22);
            lblResultTitle.Text = "📋  Your Selection Summary";
            lblResultTitle.TabIndex = 0;

            lblResultDetail.AutoSize = false;
            lblResultDetail.Font = new Font("Segoe UI", 10F);
            lblResultDetail.ForeColor = Color.FromArgb(30, 45, 80);
            lblResultDetail.Location = new Point(14, 40);
            lblResultDetail.Name = "lblResultDetail";
            lblResultDetail.Size = new Size(980, 108);
            lblResultDetail.Text = "";
            lblResultDetail.TabIndex = 1;

            // ── HIDDEN LEGACY ────────────────────────────────────────────
            panel3.Size = new Size(0, 0); panel3.Visible = false;
            genitibtn.Visible = false; backbutton.Visible = false;
            label1.Visible = false; label2.Visible = false;
            label5.Visible = false; label6.Visible = false;
            tableLayoutPanel1.Visible = false; tableLayoutPanel2.Visible = false;
            tableLayoutPanel3.Visible = false; tableLayoutPanel4.Visible = false;
            foreach (var c in new System.Windows.Forms.Control[] {
                chkBus,chkCab,chkTrain,chkBike,chkFlight,
                chkHotel,chkHomestay,chkResort,chkCamp,chkApartment,chkNoStay,
                chkVacation,chkEducation,chkBusiness,chkMedical,chkFestival,
                chkUnder1000,chk1000_3000,chk3000_5000,chk5000_10000,
                chkLuxury,chkFree,chkStudent,chkFamily })
                c.Visible = false;

            // ════════════════════════════════════════════════════════════
            //  FORM
            // ════════════════════════════════════════════════════════════
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(mainScroll);
            Controls.Add(panel2);
            Controls.Add(toppanel);
            KeyPreview = true;
            Name = "Budgetfriendly";
            Text = "Budgetfriendly";
            Load += Budgetfriendly_Load;
            Resize += Budgetfriendly_Resize;

            toppanel.ResumeLayout(false);
            toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            cardTransport.ResumeLayout(false);
            cardTransport.PerformLayout();
            cardAccommodation.ResumeLayout(false);
            cardAccommodation.PerformLayout();
            cardPurpose.ResumeLayout(false);
            cardPurpose.PerformLayout();
            cardBudget.ResumeLayout(false);
            cardBudget.PerformLayout();
            pnlResultArea.ResumeLayout(false);
            resultCard.ResumeLayout(false);
            resultCard.PerformLayout();
            innerPanel.ResumeLayout(false);
            mainScroll.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        // ════════════════════════════════════════════════════════════════
        //  DESIGNER HELPERS
        // ════════════════════════════════════════════════════════════════

        private static void BuildCard(Panel card, Point location, Size size,
                                      string title, Color accentColor)
        {
            card.BackColor = Color.White;
            card.Location = location;
            card.Size = size;
            card.BorderStyle = BorderStyle.None;

            card.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using var path = RoundedRect(new Rectangle(0, 0, card.Width - 1, card.Height - 1), 12);
                using var fill = new System.Drawing.SolidBrush(Color.White);
                g.FillPath(fill, path);
                using var border = new Pen(Color.FromArgb(218, 224, 235), 1.5f);
                g.DrawPath(border, path);
                card.Region = new Region(path);

                using var grad = new System.Drawing.Drawing2D.LinearGradientBrush(
                    new Rectangle(0, 0, card.Width, 48), accentColor,
                    ControlPaint.Light(accentColor, 0.3f),
                    System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
                using var topPath = RoundedRectTop(new Rectangle(0, 0, card.Width, 48), 12);
                g.FillPath(grad, topPath);
            };

            card.Controls.Add(new Label
            {
                AutoSize = false,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(14, 12),
                Size = new Size(size.Width - 28, 26),
                Text = title,
                TabIndex = 0
            });
            card.Controls.Add(new Panel
            {
                BackColor = Color.FromArgb(220, 228, 245),
                Location = new Point(14, 52),
                Size = new Size(size.Width - 28, 1),
                TabIndex = 1
            });
        }

        private static void AddRadioButtons(Panel card, RadioButton[] radios,
                                            string[] labels, int columns)
        {
            int colWidth = (card.Width - 28) / columns;
            int startY = 60;
            int rowHeight = Math.Max(32, (card.Height - startY - 10) /
                            (int)Math.Ceiling((double)radios.Length / columns));

            for (int i = 0; i < radios.Length; i++)
            {
                var rb = radios[i];
                rb.AutoSize = false;
                rb.BackColor = Color.Transparent;
                rb.Cursor = Cursors.Hand;
                rb.Font = new Font("Segoe UI", 10F);
                rb.ForeColor = Color.FromArgb(35, 45, 75);
                rb.Location = new Point(14 + (i % columns) * colWidth,
                                         startY + (i / columns) * rowHeight);
                rb.Size = new Size(colWidth - 8, rowHeight - 2);
                rb.Text = labels[i];
                rb.TabIndex = 10 + i;
                rb.UseVisualStyleBackColor = false;
                rb.FlatStyle = FlatStyle.Flat;
                card.Controls.Add(rb);
            }
        }

        private static System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            int d = radius * 2;
            var p = new System.Drawing.Drawing2D.GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        private static System.Drawing.Drawing2D.GraphicsPath RoundedRectTop(Rectangle r, int radius)
        {
            int d = radius * 2;
            var p = new System.Drawing.Drawing2D.GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddLine(r.Right, r.Bottom, r.X, r.Bottom);
            p.CloseFigure();
            return p;
        }

        #endregion

        // ── Unchanged ──────────────────────────────────────────────────────
        private Panel toppanel;
        private Label labelTagline, label3, label4;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button3, button4;

        // ── Layout ─────────────────────────────────────────────────────────
        private Panel mainScroll, innerPanel;
        private Panel cardTransport, cardAccommodation, cardPurpose, cardBudget;
        private Panel resultCard, pnlResultArea;

        // ── RadioButtons ───────────────────────────────────────────────────
        private RadioButton rbBus, rbCab, rbTrain, rbBike, rbFlight;
        private RadioButton rbHotel, rbHomestay, rbResort, rbCamp, rbApartment, rbNoStay;
        private RadioButton rbVacation, rbEducation, rbBusiness, rbMedical, rbFestival;
        private RadioButton rbUnder1000, rb1000_3000, rb3000_5000, rb5000_10000;
        private RadioButton rbLuxury, rbFree, rbStudent, rbFamily;

        // ── Result ─────────────────────────────────────────────────────────
        private Label lblResultTitle, lblResultDetail, lblResult;
        private Button submitbutton;

        // ── Legacy (hidden, compat) ─────────────────────────────────────────
        private TableLayoutPanel tableLayoutPanel1, tableLayoutPanel2,
                                 tableLayoutPanel3, tableLayoutPanel4;
        private Panel panel3;
        private Button genitibtn, backbutton;
        private Label label1, label2, label5, label6;
        private CheckBox chkBus, chkCab, chkTrain, chkBike, chkFlight;
        private CheckBox chkHotel, chkHomestay, chkResort, chkCamp, chkApartment, chkNoStay;
        private CheckBox chkVacation, chkEducation, chkBusiness, chkMedical, chkFestival;
        private CheckBox chkUnder1000, chk1000_3000, chk3000_5000, chk5000_10000;
        private CheckBox chkLuxury, chkFree, chkStudent, chkFamily;
    }
}
