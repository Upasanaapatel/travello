namespace traveliti
{
    partial class BookingForm
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
            panelTop = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelBottom = new Panel();
            btnBack = new Button();
            btnConfirmBooking = new Button();
            splitContainer = new SplitContainer();
            lblTripTitle = new Label();
            lblDestLabel = new Label();
            lblDestinationValue = new Label();
            lblDaysLabel = new Label();
            lblDaysValue = new Label();
            lblBudgetLabel = new Label();
            lblBudgetValue = new Label();
            lblPerDayLabel = new Label();
            lblPerDayValue = new Label();
            lblTravLabel = new Label();
            nudTravellers = new NumericUpDown();
            lblTotalLabel = new Label();
            lblTotalCostValue = new Label();
            lblItinTitle = new Label();
            rtbItinerary = new RichTextBox();
            lblFormTitle = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblTravelDate = new Label();
            dtpTravelDate = new DateTimePicker();
            lblReturnDate = new Label();
            dtpReturnDate = new DateTimePicker();
            lblSpecial = new Label();
            txtSpecial = new TextBox();
            toppanel = new Panel();
            panel5 = new Panel();
            labelTagline = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox9 = new PictureBox();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTravellers).BeginInit();
            toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(26, 82, 118);
            panelTop.Controls.Add(toppanel);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1000, 95);
            panelTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🎫   Book Your Trip";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.FromArgb(0, 0, 192);
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(128, 255, 255);
            lblSubtitle.Location = new Point(100, 67);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(700, 26);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Fill in your details to confirm the booking";
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(26, 82, 118);
            panelBottom.Controls.Add(btnBack);
            panelBottom.Controls.Add(btnConfirmBooking);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 638);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1000, 62);
            panelBottom.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(26, 82, 118);
            btnBack.Location = new Point(14, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 38);
            btnBack.TabIndex = 0;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnConfirmBooking
            // 
            btnConfirmBooking.BackColor = Color.FromArgb(39, 174, 96);
            btnConfirmBooking.Cursor = Cursors.Hand;
            btnConfirmBooking.FlatAppearance.BorderSize = 0;
            btnConfirmBooking.FlatStyle = FlatStyle.Flat;
            btnConfirmBooking.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnConfirmBooking.ForeColor = Color.White;
            btnConfirmBooking.Location = new Point(148, 12);
            btnConfirmBooking.Name = "btnConfirmBooking";
            btnConfirmBooking.Size = new Size(190, 38);
            btnConfirmBooking.TabIndex = 1;
            btnConfirmBooking.Text = "✅  Confirm Booking";
            btnConfirmBooking.UseVisualStyleBackColor = false;
            btnConfirmBooking.Click += btnConfirmBooking_Click;
            // 
            // splitContainer
            // 
            splitContainer.BackColor = Color.FromArgb(230, 235, 240);
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 95);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.AutoScroll = true;
            splitContainer.Panel1.BackColor = Color.White;
            splitContainer.Panel1.Controls.Add(lblTripTitle);
            splitContainer.Panel1.Controls.Add(lblDestLabel);
            splitContainer.Panel1.Controls.Add(lblDestinationValue);
            splitContainer.Panel1.Controls.Add(lblDaysLabel);
            splitContainer.Panel1.Controls.Add(lblDaysValue);
            splitContainer.Panel1.Controls.Add(lblBudgetLabel);
            splitContainer.Panel1.Controls.Add(lblBudgetValue);
            splitContainer.Panel1.Controls.Add(lblPerDayLabel);
            splitContainer.Panel1.Controls.Add(lblPerDayValue);
            splitContainer.Panel1.Controls.Add(lblTravLabel);
            splitContainer.Panel1.Controls.Add(nudTravellers);
            splitContainer.Panel1.Controls.Add(lblTotalLabel);
            splitContainer.Panel1.Controls.Add(lblTotalCostValue);
            splitContainer.Panel1.Controls.Add(lblItinTitle);
            splitContainer.Panel1.Controls.Add(rtbItinerary);
            splitContainer.Panel1.Padding = new Padding(20, 16, 20, 16);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.AutoScroll = true;
            splitContainer.Panel2.BackColor = Color.White;
            splitContainer.Panel2.Controls.Add(lblFormTitle);
            splitContainer.Panel2.Controls.Add(lblFullName);
            splitContainer.Panel2.Controls.Add(txtFullName);
            splitContainer.Panel2.Controls.Add(lblEmail);
            splitContainer.Panel2.Controls.Add(txtEmail);
            splitContainer.Panel2.Controls.Add(lblPhone);
            splitContainer.Panel2.Controls.Add(txtPhone);
            splitContainer.Panel2.Controls.Add(lblTravelDate);
            splitContainer.Panel2.Controls.Add(dtpTravelDate);
            splitContainer.Panel2.Controls.Add(lblReturnDate);
            splitContainer.Panel2.Controls.Add(dtpReturnDate);
            splitContainer.Panel2.Controls.Add(lblSpecial);
            splitContainer.Panel2.Controls.Add(txtSpecial);
            splitContainer.Panel2.Padding = new Padding(20, 16, 20, 16);
            splitContainer.Size = new Size(1000, 543);
            splitContainer.SplitterDistance = 806;
            splitContainer.SplitterWidth = 8;
            splitContainer.TabIndex = 0;
            // 
            // lblTripTitle
            // 
            lblTripTitle.AutoSize = true;
            lblTripTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTripTitle.ForeColor = Color.FromArgb(26, 82, 118);
            lblTripTitle.Location = new Point(20, 81);
            lblTripTitle.Name = "lblTripTitle";
            lblTripTitle.Size = new Size(163, 25);
            lblTripTitle.TabIndex = 0;
            lblTripTitle.Text = "📋  Trip Summary";
            // 
            // lblDestLabel
            // 
            lblDestLabel.Location = new Point(0, 0);
            lblDestLabel.Name = "lblDestLabel";
            lblDestLabel.Size = new Size(100, 23);
            lblDestLabel.TabIndex = 1;
            // 
            // lblDestinationValue
            // 
            lblDestinationValue.Location = new Point(0, 0);
            lblDestinationValue.Name = "lblDestinationValue";
            lblDestinationValue.Size = new Size(100, 23);
            lblDestinationValue.TabIndex = 2;
            // 
            // lblDaysLabel
            // 
            lblDaysLabel.Location = new Point(0, 0);
            lblDaysLabel.Name = "lblDaysLabel";
            lblDaysLabel.Size = new Size(100, 23);
            lblDaysLabel.TabIndex = 3;
            // 
            // lblDaysValue
            // 
            lblDaysValue.Location = new Point(0, 0);
            lblDaysValue.Name = "lblDaysValue";
            lblDaysValue.Size = new Size(100, 23);
            lblDaysValue.TabIndex = 4;
            // 
            // lblBudgetLabel
            // 
            lblBudgetLabel.Location = new Point(0, 0);
            lblBudgetLabel.Name = "lblBudgetLabel";
            lblBudgetLabel.Size = new Size(100, 23);
            lblBudgetLabel.TabIndex = 5;
            // 
            // lblBudgetValue
            // 
            lblBudgetValue.Location = new Point(0, 0);
            lblBudgetValue.Name = "lblBudgetValue";
            lblBudgetValue.Size = new Size(100, 23);
            lblBudgetValue.TabIndex = 6;
            // 
            // lblPerDayLabel
            // 
            lblPerDayLabel.Location = new Point(0, 0);
            lblPerDayLabel.Name = "lblPerDayLabel";
            lblPerDayLabel.Size = new Size(100, 23);
            lblPerDayLabel.TabIndex = 7;
            // 
            // lblPerDayValue
            // 
            lblPerDayValue.Location = new Point(0, 0);
            lblPerDayValue.Name = "lblPerDayValue";
            lblPerDayValue.Size = new Size(100, 23);
            lblPerDayValue.TabIndex = 8;
            // 
            // lblTravLabel
            // 
            lblTravLabel.Location = new Point(0, 0);
            lblTravLabel.Name = "lblTravLabel";
            lblTravLabel.Size = new Size(100, 23);
            lblTravLabel.TabIndex = 9;
            // 
            // nudTravellers
            // 
            nudTravellers.Font = new Font("Segoe UI", 10F);
            nudTravellers.Location = new Point(180, 202);
            nudTravellers.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudTravellers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTravellers.Name = "nudTravellers";
            nudTravellers.Size = new Size(72, 25);
            nudTravellers.TabIndex = 10;
            nudTravellers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudTravellers.ValueChanged += nudTravellers_ValueChanged;
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.Location = new Point(0, 0);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(100, 23);
            lblTotalLabel.TabIndex = 11;
            // 
            // lblTotalCostValue
            // 
            lblTotalCostValue.AutoSize = true;
            lblTotalCostValue.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTotalCostValue.ForeColor = Color.FromArgb(192, 57, 43);
            lblTotalCostValue.Location = new Point(180, 244);
            lblTotalCostValue.Name = "lblTotalCostValue";
            lblTotalCostValue.Size = new Size(37, 25);
            lblTotalCostValue.TabIndex = 12;
            lblTotalCostValue.Text = "₹ 0";
            // 
            // lblItinTitle
            // 
            lblItinTitle.AutoSize = true;
            lblItinTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblItinTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblItinTitle.Location = new Point(20, 286);
            lblItinTitle.Name = "lblItinTitle";
            lblItinTitle.Size = new Size(137, 17);
            lblItinTitle.TabIndex = 13;
            lblItinTitle.Text = "📄 Itinerary Preview:";
            // 
            // rtbItinerary
            // 
            rtbItinerary.BackColor = Color.FromArgb(245, 248, 252);
            rtbItinerary.BorderStyle = BorderStyle.FixedSingle;
            rtbItinerary.Font = new Font("Consolas", 8F);
            rtbItinerary.Location = new Point(20, 312);
            rtbItinerary.Name = "rtbItinerary";
            rtbItinerary.ReadOnly = true;
            rtbItinerary.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbItinerary.Size = new Size(370, 260);
            rtbItinerary.TabIndex = 14;
            rtbItinerary.Text = "";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(26, 82, 118);
            lblFormTitle.Location = new Point(20, 16);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(181, 25);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "👤  Traveller Details";
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(0, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 23);
            lblFullName.TabIndex = 1;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(0, 0);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 24);
            txtFullName.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(0, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(0, 0);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 24);
            txtEmail.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(0, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(0, 0);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 24);
            txtPhone.TabIndex = 6;
            // 
            // lblTravelDate
            // 
            lblTravelDate.Location = new Point(0, 0);
            lblTravelDate.Name = "lblTravelDate";
            lblTravelDate.Size = new Size(100, 23);
            lblTravelDate.TabIndex = 7;
            // 
            // dtpTravelDate
            // 
            dtpTravelDate.Font = new Font("Segoe UI", 10F);
            dtpTravelDate.Location = new Point(20, 290);
            dtpTravelDate.Name = "dtpTravelDate";
            dtpTravelDate.Size = new Size(360, 25);
            dtpTravelDate.TabIndex = 8;
            dtpTravelDate.ValueChanged += dtpTravelDate_ValueChanged;
            // 
            // lblReturnDate
            // 
            lblReturnDate.Location = new Point(0, 0);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(100, 23);
            lblReturnDate.TabIndex = 9;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Font = new Font("Segoe UI", 10F);
            dtpReturnDate.Location = new Point(20, 358);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(360, 25);
            dtpReturnDate.TabIndex = 10;
            // 
            // lblSpecial
            // 
            lblSpecial.Location = new Point(0, 0);
            lblSpecial.Name = "lblSpecial";
            lblSpecial.Size = new Size(100, 23);
            lblSpecial.TabIndex = 11;
            // 
            // txtSpecial
            // 
            txtSpecial.BackColor = Color.FromArgb(245, 248, 252);
            txtSpecial.BorderStyle = BorderStyle.FixedSingle;
            txtSpecial.Font = new Font("Segoe UI", 9.5F);
            txtSpecial.Location = new Point(20, 426);
            txtSpecial.Multiline = true;
            txtSpecial.Name = "txtSpecial";
            txtSpecial.ScrollBars = ScrollBars.Vertical;
            txtSpecial.Size = new Size(360, 90);
            txtSpecial.TabIndex = 12;
            // 
            // toppanel
            // 
            toppanel.BackColor = Color.White;
            toppanel.BorderStyle = BorderStyle.Fixed3D;
            toppanel.Controls.Add(panel5);
            toppanel.Controls.Add(lblSubtitle);
            toppanel.Controls.Add(labelTagline);
            toppanel.Controls.Add(label3);
            toppanel.Controls.Add(label4);
            toppanel.Controls.Add(pictureBox9);
            toppanel.Dock = DockStyle.Top;
            toppanel.ImeMode = ImeMode.Katakana;
            toppanel.Location = new Point(0, 0);
            toppanel.Name = "toppanel";
            toppanel.Size = new Size(1000, 95);
            toppanel.TabIndex = 32;
            toppanel.UseWaitCursor = true;
            // 
            // panel5
            // 
            panel5.Location = new Point(227, 77);
            panel5.Name = "panel5";
            panel5.Size = new Size(0, 0);
            panel5.TabIndex = 2;
            panel5.UseWaitCursor = true;
            // 
            // labelTagline
            // 
            labelTagline.AutoSize = true;
            labelTagline.ForeColor = Color.Navy;
            labelTagline.Location = new Point(116, 41);
            labelTagline.Name = "labelTagline";
            labelTagline.Size = new Size(164, 17);
            labelTagline.TabIndex = 4;
            labelTagline.Text = "Your Perfect Escape Awaits";
            labelTagline.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 36);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 3;
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.MenuBar;
            label4.AllowDrop = true;
            label4.AutoEllipsis = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(100, 9);
            label4.Name = "label4";
            label4.Size = new Size(304, 42);
            label4.TabIndex = 2;
            label4.Text = "Travel Itinerary";
            label4.UseWaitCursor = true;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.travel;
            pictureBox9.Location = new Point(0, -21);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(100, 121);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            pictureBox9.UseWaitCursor = true;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 235, 240);
            ClientSize = new Size(1000, 700);
            Controls.Add(splitContainer);
            Controls.Add(panelTop);
            Controls.Add(panelBottom);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(900, 650);
            Name = "BookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Your Trip - Traveliti";
            WindowState = FormWindowState.Maximized;
            Load += BookingForm_Load;
            panelTop.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudTravellers).EndInit();
            toppanel.ResumeLayout(false);
            toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        // ── Helpers ──────────────────────────────────────────────────────
        private void SetRow(System.Windows.Forms.Label lbl, string text, int x, int y)
        {
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110);
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.AutoSize = true;
        }

        private void SetVal(System.Windows.Forms.Label lbl, string text, int x, int y,
                            bool bold = false, bool big = false)
        {
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI",
                                big ? 11F : 9.5F,
                                bold ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular);
            lbl.ForeColor = System.Drawing.Color.FromArgb(30, 30, 50);
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.AutoSize = true;
        }

        private void SetFormLabel(System.Windows.Forms.Label lbl, string text, int x, int y)
        {
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(50, 60, 80);
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.AutoSize = true;
        }

        private void SetTextBox(System.Windows.Forms.TextBox tb, int x, int y)
        {
            tb.Location = new System.Drawing.Point(x, y);
            tb.Size = new System.Drawing.Size(360, 34);
            tb.Font = new System.Drawing.Font("Segoe UI", 11F);
            tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tb.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
        }

        #endregion

        // ── Declarations ─────────────────────────────────────────────────
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirmBooking;

        // Left
        private System.Windows.Forms.Label lblTripTitle;
        private System.Windows.Forms.Label lblDestLabel;
        private System.Windows.Forms.Label lblDestinationValue;
        private System.Windows.Forms.Label lblDaysLabel;
        private System.Windows.Forms.Label lblDaysValue;
        private System.Windows.Forms.Label lblBudgetLabel;
        private System.Windows.Forms.Label lblBudgetValue;
        private System.Windows.Forms.Label lblPerDayLabel;
        private System.Windows.Forms.Label lblPerDayValue;
        private System.Windows.Forms.Label lblTravLabel;
        private System.Windows.Forms.NumericUpDown nudTravellers;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalCostValue;
        private System.Windows.Forms.Label lblItinTitle;
        private System.Windows.Forms.RichTextBox rtbItinerary;

        // Right
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblTravelDate;
        private System.Windows.Forms.DateTimePicker dtpTravelDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.TextBox txtSpecial;
        private Panel toppanel;
        private Panel panel5;
        private Label labelTagline;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox9;
    }
}