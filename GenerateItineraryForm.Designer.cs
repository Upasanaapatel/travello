namespace traveliti
{
    partial class GenerateItineraryForm
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
            lblSubtitle = new Label();
            panelBottom = new Panel();
            btnBack = new Button();
            btnGenerate = new Button();
            btnSave = new Button();
            btnBook = new Button();
            panelCenter = new Panel();
            lblDays = new Label();
            nudDays = new NumericUpDown();
            lblSelectLabel = new Label();
            chkSightseeing = new CheckBox();
            chkAdventure = new CheckBox();
            chkFoodTour = new CheckBox();
            chkShopping = new CheckBox();
            chkCultural = new CheckBox();
            chkNature = new CheckBox();
            chkBeach = new CheckBox();
            chkNightlife = new CheckBox();
            chkSpa = new CheckBox();
            chkPhotography = new CheckBox();
            lblItineraryOutput = new Label();
            rtbItinerary = new RichTextBox();
            lblTitle = new Label();
            panelTop = new Panel();
            toppanel = new Panel();
            panel5 = new Panel();
            labelTagline = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox9 = new PictureBox();
            panelBottom.SuspendLayout();
            panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDays).BeginInit();
            panelTop.SuspendLayout();
            toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(0, 0, 192);
            lblSubtitle.Location = new Point(100, 67);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(750, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Destination: ...   |   Budget: ₹ ...";
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(26, 82, 118);
            panelBottom.Controls.Add(btnBack);
            panelBottom.Controls.Add(btnGenerate);
            panelBottom.Controls.Add(btnSave);
            panelBottom.Controls.Add(btnBook);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 658);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1370, 62);
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
            btnBack.Size = new Size(110, 38);
            btnBack.TabIndex = 0;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(230, 126, 34);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(138, 12);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(155, 38);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "⚡ Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(39, 174, 96);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Enabled = false;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(307, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 38);
            btnSave.TabIndex = 2;
            btnSave.Text = "💾 Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(192, 57, 43);
            btnBook.Cursor = Cursors.Hand;
            btnBook.Enabled = false;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(461, 12);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(140, 38);
            btnBook.TabIndex = 3;
            btnBook.Text = "🎫 Book Now";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // panelCenter
            // 
            panelCenter.AutoScroll = true;
            panelCenter.BackColor = Color.FromArgb(245, 248, 252);
            panelCenter.Controls.Add(lblDays);
            panelCenter.Controls.Add(nudDays);
            panelCenter.Controls.Add(lblSelectLabel);
            panelCenter.Controls.Add(chkSightseeing);
            panelCenter.Controls.Add(chkAdventure);
            panelCenter.Controls.Add(chkFoodTour);
            panelCenter.Controls.Add(chkShopping);
            panelCenter.Controls.Add(chkCultural);
            panelCenter.Controls.Add(chkNature);
            panelCenter.Controls.Add(chkBeach);
            panelCenter.Controls.Add(chkNightlife);
            panelCenter.Controls.Add(chkSpa);
            panelCenter.Controls.Add(chkPhotography);
            panelCenter.Controls.Add(lblItineraryOutput);
            panelCenter.Controls.Add(rtbItinerary);
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(0, 100);
            panelCenter.Name = "panelCenter";
            panelCenter.Padding = new Padding(24, 18, 24, 18);
            panelCenter.Size = new Size(1370, 558);
            panelCenter.TabIndex = 0;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDays.ForeColor = Color.FromArgb(44, 62, 80);
            lblDays.Location = new Point(24, 24);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(122, 19);
            lblDays.TabIndex = 0;
            lblDays.Text = "Number of Days:";
            // 
            // nudDays
            // 
            nudDays.Font = new Font("Segoe UI", 10F);
            nudDays.Location = new Point(178, 21);
            nudDays.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDays.Name = "nudDays";
            nudDays.Size = new Size(68, 25);
            nudDays.TabIndex = 1;
            nudDays.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblSelectLabel
            // 
            lblSelectLabel.AutoSize = true;
            lblSelectLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSelectLabel.ForeColor = Color.FromArgb(44, 62, 80);
            lblSelectLabel.Location = new Point(24, 64);
            lblSelectLabel.Name = "lblSelectLabel";
            lblSelectLabel.Size = new Size(188, 19);
            lblSelectLabel.TabIndex = 2;
            lblSelectLabel.Text = "Select Activities to Include:";
            // 
            // chkSightseeing
            // 
            chkSightseeing.Location = new Point(0, 0);
            chkSightseeing.Name = "chkSightseeing";
            chkSightseeing.Size = new Size(104, 24);
            chkSightseeing.TabIndex = 3;
            // 
            // chkAdventure
            // 
            chkAdventure.Location = new Point(0, 0);
            chkAdventure.Name = "chkAdventure";
            chkAdventure.Size = new Size(104, 24);
            chkAdventure.TabIndex = 4;
            // 
            // chkFoodTour
            // 
            chkFoodTour.Location = new Point(0, 0);
            chkFoodTour.Name = "chkFoodTour";
            chkFoodTour.Size = new Size(104, 24);
            chkFoodTour.TabIndex = 5;
            // 
            // chkShopping
            // 
            chkShopping.Location = new Point(0, 0);
            chkShopping.Name = "chkShopping";
            chkShopping.Size = new Size(104, 24);
            chkShopping.TabIndex = 6;
            // 
            // chkCultural
            // 
            chkCultural.Location = new Point(0, 0);
            chkCultural.Name = "chkCultural";
            chkCultural.Size = new Size(104, 24);
            chkCultural.TabIndex = 7;
            // 
            // chkNature
            // 
            chkNature.Location = new Point(0, 0);
            chkNature.Name = "chkNature";
            chkNature.Size = new Size(104, 24);
            chkNature.TabIndex = 8;
            // 
            // chkBeach
            // 
            chkBeach.Location = new Point(0, 0);
            chkBeach.Name = "chkBeach";
            chkBeach.Size = new Size(104, 24);
            chkBeach.TabIndex = 9;
            // 
            // chkNightlife
            // 
            chkNightlife.Location = new Point(0, 0);
            chkNightlife.Name = "chkNightlife";
            chkNightlife.Size = new Size(104, 24);
            chkNightlife.TabIndex = 10;
            // 
            // chkSpa
            // 
            chkSpa.Location = new Point(0, 0);
            chkSpa.Name = "chkSpa";
            chkSpa.Size = new Size(104, 24);
            chkSpa.TabIndex = 11;
            // 
            // chkPhotography
            // 
            chkPhotography.Location = new Point(0, 0);
            chkPhotography.Name = "chkPhotography";
            chkPhotography.Size = new Size(104, 24);
            chkPhotography.TabIndex = 12;
            // 
            // lblItineraryOutput
            // 
            lblItineraryOutput.AutoSize = true;
            lblItineraryOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblItineraryOutput.ForeColor = Color.FromArgb(44, 62, 80);
            lblItineraryOutput.Location = new Point(24, 298);
            lblItineraryOutput.Name = "lblItineraryOutput";
            lblItineraryOutput.Size = new Size(145, 19);
            lblItineraryOutput.TabIndex = 13;
            lblItineraryOutput.Text = "Generated Itinerary:";
            lblItineraryOutput.Visible = false;
            // 
            // rtbItinerary
            // 
            rtbItinerary.BackColor = Color.White;
            rtbItinerary.BorderStyle = BorderStyle.FixedSingle;
            rtbItinerary.Font = new Font("Consolas", 9.5F);
            rtbItinerary.Location = new Point(24, 326);
            rtbItinerary.Name = "rtbItinerary";
            rtbItinerary.ReadOnly = true;
            rtbItinerary.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbItinerary.Size = new Size(830, 310);
            rtbItinerary.TabIndex = 14;
            rtbItinerary.Text = "";
            rtbItinerary.Visible = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "✈   Generate Itinerary";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(26, 82, 118);
            panelTop.Controls.Add(toppanel);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(20, 10, 20, 10);
            panelTop.Size = new Size(1370, 100);
            panelTop.TabIndex = 1;
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
            toppanel.ImeMode = ImeMode.Katakana;
            toppanel.Location = new Point(0, 0);
            toppanel.Name = "toppanel";
            toppanel.Size = new Size(1370, 100);
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
            // GenerateItineraryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(1370, 720);
            Controls.Add(panelCenter);
            Controls.Add(panelTop);
            Controls.Add(panelBottom);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(820, 640);
            Name = "GenerateItineraryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generate Itinerary";
            Load += GenerateItineraryForm_Load;
            panelBottom.ResumeLayout(false);
            panelCenter.ResumeLayout(false);
            panelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDays).EndInit();
            panelTop.ResumeLayout(false);
            toppanel.ResumeLayout(false);
            toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        // Helper to configure CheckBox style
        private void MakeChk(System.Windows.Forms.CheckBox cb, string text, int x, int y)
        {
            cb.Text = text;
            cb.Location = new System.Drawing.Point(x, y);
            cb.Size = new System.Drawing.Size(230, 30);
            cb.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cb.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            cb.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        #endregion
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblSelectLabel;
        private System.Windows.Forms.Label lblItineraryOutput;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.CheckBox chkSightseeing;
        private System.Windows.Forms.CheckBox chkAdventure;
        private System.Windows.Forms.CheckBox chkFoodTour;
        private System.Windows.Forms.CheckBox chkShopping;
        private System.Windows.Forms.CheckBox chkCultural;
        private System.Windows.Forms.CheckBox chkNature;
        private System.Windows.Forms.CheckBox chkBeach;
        private System.Windows.Forms.CheckBox chkNightlife;
        private System.Windows.Forms.CheckBox chkSpa;
        private System.Windows.Forms.CheckBox chkPhotography;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.RichTextBox rtbItinerary;
        private Label lblTitle;
        private Panel panelTop;
        private Panel toppanel;
        private Panel panel5;
        private Label labelTagline;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox9;
    }
}