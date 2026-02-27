namespace traveliti
{
    partial class Contact
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
            mainPanel = new Panel();
            cardPanel = new Panel();
            lblPageTitle = new Label();
            lblPageSub = new Label();
            divider = new Panel();
            iconName = new Label();
            lblName = new Label();
            txtName = new TextBox();
            iconEmail = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            iconPhone = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            iconSubject = new Label();
            lblSubject = new Label();
            txtSubject = new TextBox();
            iconMessage = new Label();
            lblMessage = new Label();
            txtMessage = new RichTextBox();
            btnSend = new Button();
            btnClear = new Button();
            btnBack = new Button();
            lblStatus = new Label();
            infoCard = new Panel();
            lblInfoTitle = new Label();
            lblInfoDivider = new Panel();
            lblPhone1Icon = new Label();
            lblPhone1 = new Label();
            lblPhone1Val = new Label();
            lblEmailIcon = new Label();
            lblEmailLbl = new Label();
            lblEmailVal = new Label();
            lblAddrIcon = new Label();
            lblAddrLbl = new Label();
            lblAddrVal = new Label();
            lblHoursIcon = new Label();
            lblHoursLbl = new Label();
            lblHoursVal = new Label();
            lblSocialTitle = new Label();
            btnFacebook = new Button();
            btnInstagram = new Button();
            btnTwitter = new Button();
            btnWhatsApp = new Button();
            mainPanel.SuspendLayout();
            cardPanel.SuspendLayout();
            infoCard.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = Color.FromArgb(240, 244, 248);
            mainPanel.Controls.Add(cardPanel);
            mainPanel.Controls.Add(infoCard);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(30, 24, 30, 24);
            mainPanel.Size = new Size(1200, 749);
            mainPanel.TabIndex = 1;
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.White;
            cardPanel.Controls.Add(lblPageTitle);
            cardPanel.Controls.Add(lblPageSub);
            cardPanel.Controls.Add(divider);
            cardPanel.Controls.Add(iconName);
            cardPanel.Controls.Add(lblName);
            cardPanel.Controls.Add(txtName);
            cardPanel.Controls.Add(iconEmail);
            cardPanel.Controls.Add(lblEmail);
            cardPanel.Controls.Add(txtEmail);
            cardPanel.Controls.Add(iconPhone);
            cardPanel.Controls.Add(lblPhone);
            cardPanel.Controls.Add(txtPhone);
            cardPanel.Controls.Add(iconSubject);
            cardPanel.Controls.Add(lblSubject);
            cardPanel.Controls.Add(txtSubject);
            cardPanel.Controls.Add(iconMessage);
            cardPanel.Controls.Add(lblMessage);
            cardPanel.Controls.Add(txtMessage);
            cardPanel.Controls.Add(btnSend);
            cardPanel.Controls.Add(btnClear);
            cardPanel.Controls.Add(btnBack);
            cardPanel.Controls.Add(lblStatus);
            cardPanel.Location = new Point(30, 24);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(640, 660);
            cardPanel.TabIndex = 2;
            cardPanel.Paint += CardPanel_Paint;
            // 
            // lblPageTitle
            // 
            lblPageTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(20, 30, 60);
            lblPageTitle.Location = new Point(24, 20);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(590, 36);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "✉️  Get In Touch";
            // 
            // lblPageSub
            // 
            lblPageSub.Font = new Font("Segoe UI", 9.5F);
            lblPageSub.ForeColor = Color.FromArgb(120, 130, 155);
            lblPageSub.Location = new Point(24, 56);
            lblPageSub.Name = "lblPageSub";
            lblPageSub.Size = new Size(590, 20);
            lblPageSub.TabIndex = 1;
            lblPageSub.Text = "We'd love to hear from you. Fill out the form and we'll get back to you soon.";
            // 
            // divider
            // 
            divider.BackColor = Color.FromArgb(230, 235, 245);
            divider.Location = new Point(24, 82);
            divider.Name = "divider";
            divider.Size = new Size(590, 1);
            divider.TabIndex = 2;
            // 
            // iconName
            // 
            iconName.AutoSize = true;
            iconName.Font = new Font("Segoe UI Emoji", 13F);
            iconName.Location = new Point(24, 96);
            iconName.Name = "iconName";
            iconName.Size = new Size(31, 24);
            iconName.TabIndex = 3;
            iconName.Text = "👤";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(50, 60, 90);
            lblName.Location = new Point(50, 99);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Full Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(247, 249, 253);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(24, 120);
            txtName.Name = "txtName";
            txtName.Size = new Size(590, 25);
            txtName.TabIndex = 5;
            // 
            // iconEmail
            // 
            iconEmail.AutoSize = true;
            iconEmail.Font = new Font("Segoe UI Emoji", 13F);
            iconEmail.Location = new Point(24, 164);
            iconEmail.Name = "iconEmail";
            iconEmail.Size = new Size(35, 24);
            iconEmail.TabIndex = 6;
            iconEmail.Text = "📧";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(50, 60, 90);
            lblEmail.Location = new Point(50, 167);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(247, 249, 253);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(24, 188);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(590, 25);
            txtEmail.TabIndex = 8;
            // 
            // iconPhone
            // 
            iconPhone.AutoSize = true;
            iconPhone.Font = new Font("Segoe UI Emoji", 13F);
            iconPhone.Location = new Point(24, 232);
            iconPhone.Name = "iconPhone";
            iconPhone.Size = new Size(27, 24);
            iconPhone.TabIndex = 9;
            iconPhone.Text = "📱";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(50, 60, 90);
            lblPhone.Location = new Point(50, 235);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(91, 15);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(247, 249, 253);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(24, 256);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(590, 25);
            txtPhone.TabIndex = 11;
            // 
            // iconSubject
            // 
            iconSubject.AutoSize = true;
            iconSubject.Font = new Font("Segoe UI Emoji", 13F);
            iconSubject.Location = new Point(24, 300);
            iconSubject.Name = "iconSubject";
            iconSubject.Size = new Size(35, 24);
            iconSubject.TabIndex = 12;
            iconSubject.Text = "📝";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubject.ForeColor = Color.FromArgb(50, 60, 90);
            lblSubject.Location = new Point(50, 303);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(49, 15);
            lblSubject.TabIndex = 13;
            lblSubject.Text = "Subject";
            lblSubject.Click += lblSubject_Click;
            // 
            // txtSubject
            // 
            txtSubject.BackColor = Color.FromArgb(247, 249, 253);
            txtSubject.BorderStyle = BorderStyle.FixedSingle;
            txtSubject.Font = new Font("Segoe UI", 10F);
            txtSubject.Location = new Point(24, 324);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(590, 25);
            txtSubject.TabIndex = 14;
            // 
            // iconMessage
            // 
            iconMessage.AutoSize = true;
            iconMessage.Font = new Font("Segoe UI Emoji", 13F);
            iconMessage.Location = new Point(24, 368);
            iconMessage.Name = "iconMessage";
            iconMessage.Size = new Size(35, 24);
            iconMessage.TabIndex = 15;
            iconMessage.Text = "💬";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMessage.ForeColor = Color.FromArgb(50, 60, 90);
            lblMessage.Location = new Point(50, 371);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(83, 15);
            lblMessage.TabIndex = 16;
            lblMessage.Text = "Your Message";
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.FromArgb(247, 249, 253);
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.Font = new Font("Segoe UI", 10F);
            txtMessage.Location = new Point(24, 392);
            txtMessage.Name = "txtMessage";
            txtMessage.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtMessage.Size = new Size(590, 130);
            txtMessage.TabIndex = 17;
            txtMessage.Text = "";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(41, 98, 255);
            btnSend.Cursor = Cursors.Hand;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(24, 544);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(160, 44);
            btnSend.TabIndex = 18;
            btnSend.Text = "📨  Send Message";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(200, 210, 230);
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(100, 110, 140);
            btnClear.Location = new Point(200, 544);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 44);
            btnClear.TabIndex = 19;
            btnClear.Text = "🗑  Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(220, 60, 60);
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(220, 60, 60);
            btnBack.Location = new Point(338, 544);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 44);
            btnBack.TabIndex = 20;
            btnBack.Text = "🔁  Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            lblStatus.Location = new Point(24, 600);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(590, 22);
            lblStatus.TabIndex = 21;
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // infoCard
            // 
            infoCard.BackColor = Color.White;
            infoCard.Controls.Add(lblInfoTitle);
            infoCard.Controls.Add(lblInfoDivider);
            infoCard.Controls.Add(lblPhone1Icon);
            infoCard.Controls.Add(lblPhone1);
            infoCard.Controls.Add(lblPhone1Val);
            infoCard.Controls.Add(lblEmailIcon);
            infoCard.Controls.Add(lblEmailLbl);
            infoCard.Controls.Add(lblEmailVal);
            infoCard.Controls.Add(lblAddrIcon);
            infoCard.Controls.Add(lblAddrLbl);
            infoCard.Controls.Add(lblAddrVal);
            infoCard.Controls.Add(lblHoursIcon);
            infoCard.Controls.Add(lblHoursLbl);
            infoCard.Controls.Add(lblHoursVal);
            infoCard.Controls.Add(lblSocialTitle);
            infoCard.Controls.Add(btnFacebook);
            infoCard.Controls.Add(btnInstagram);
            infoCard.Controls.Add(btnTwitter);
            infoCard.Controls.Add(btnWhatsApp);
            infoCard.Location = new Point(700, 24);
            infoCard.Name = "infoCard";
            infoCard.Size = new Size(450, 660);
            infoCard.TabIndex = 3;
            infoCard.Paint += InfoCard_Paint;
            // 
            // lblInfoTitle
            // 
            lblInfoTitle.BackColor = Color.Transparent;
            lblInfoTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInfoTitle.ForeColor = Color.White;
            lblInfoTitle.Location = new Point(16, 14);
            lblInfoTitle.Name = "lblInfoTitle";
            lblInfoTitle.Size = new Size(418, 28);
            lblInfoTitle.TabIndex = 0;
            lblInfoTitle.Text = "📍  Contact Information";
            // 
            // lblInfoDivider
            // 
            lblInfoDivider.BackColor = Color.FromArgb(180, 210, 255);
            lblInfoDivider.Location = new Point(16, 52);
            lblInfoDivider.Name = "lblInfoDivider";
            lblInfoDivider.Size = new Size(418, 1);
            lblInfoDivider.TabIndex = 1;
            // 
            // lblPhone1Icon
            // 
            lblPhone1Icon.AutoSize = true;
            lblPhone1Icon.Font = new Font("Segoe UI Emoji", 18F);
            lblPhone1Icon.Location = new Point(16, 66);
            lblPhone1Icon.Name = "lblPhone1Icon";
            lblPhone1Icon.Size = new Size(45, 32);
            lblPhone1Icon.TabIndex = 2;
            lblPhone1Icon.Text = "📞";
            // 
            // lblPhone1
            // 
            lblPhone1.AutoSize = true;
            lblPhone1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone1.ForeColor = Color.FromArgb(50, 60, 90);
            lblPhone1.Location = new Point(60, 68);
            lblPhone1.Name = "lblPhone1";
            lblPhone1.Size = new Size(42, 15);
            lblPhone1.TabIndex = 3;
            lblPhone1.Text = "Phone";
            // 
            // lblPhone1Val
            // 
            lblPhone1Val.AutoSize = true;
            lblPhone1Val.Font = new Font("Segoe UI", 10F);
            lblPhone1Val.ForeColor = Color.FromArgb(30, 40, 80);
            lblPhone1Val.Location = new Point(60, 86);
            lblPhone1Val.Name = "lblPhone1Val";
            lblPhone1Val.Size = new Size(250, 19);
            lblPhone1Val.TabIndex = 4;
            lblPhone1Val.Text = "+91 98765 43210 / +91 87654 32109";
            // 
            // lblEmailIcon
            // 
            lblEmailIcon.AutoSize = true;
            lblEmailIcon.Font = new Font("Segoe UI Emoji", 18F);
            lblEmailIcon.Location = new Point(16, 130);
            lblEmailIcon.Name = "lblEmailIcon";
            lblEmailIcon.Size = new Size(47, 32);
            lblEmailIcon.TabIndex = 5;
            lblEmailIcon.Text = "✉️";
            // 
            // lblEmailLbl
            // 
            lblEmailLbl.AutoSize = true;
            lblEmailLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmailLbl.ForeColor = Color.FromArgb(50, 60, 90);
            lblEmailLbl.Location = new Point(60, 132);
            lblEmailLbl.Name = "lblEmailLbl";
            lblEmailLbl.Size = new Size(36, 15);
            lblEmailLbl.TabIndex = 6;
            lblEmailLbl.Text = "Email";
            // 
            // lblEmailVal
            // 
            lblEmailVal.AutoSize = true;
            lblEmailVal.Cursor = Cursors.Hand;
            lblEmailVal.Font = new Font("Segoe UI", 10F);
            lblEmailVal.ForeColor = Color.FromArgb(41, 98, 255);
            lblEmailVal.Location = new Point(60, 150);
            lblEmailVal.Name = "lblEmailVal";
            lblEmailVal.Size = new Size(144, 19);
            lblEmailVal.TabIndex = 7;
            lblEmailVal.Text = "support@traveliti.com";
            lblEmailVal.Click += lblEmailVal_Click;
            // 
            // lblAddrIcon
            // 
            lblAddrIcon.AutoSize = true;
            lblAddrIcon.Font = new Font("Segoe UI Emoji", 18F);
            lblAddrIcon.Location = new Point(16, 194);
            lblAddrIcon.Name = "lblAddrIcon";
            lblAddrIcon.Size = new Size(47, 32);
            lblAddrIcon.TabIndex = 8;
            lblAddrIcon.Text = "🏢";
            // 
            // lblAddrLbl
            // 
            lblAddrLbl.AutoSize = true;
            lblAddrLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddrLbl.ForeColor = Color.FromArgb(50, 60, 90);
            lblAddrLbl.Location = new Point(60, 196);
            lblAddrLbl.Name = "lblAddrLbl";
            lblAddrLbl.Size = new Size(89, 15);
            lblAddrLbl.TabIndex = 9;
            lblAddrLbl.Text = "Office Address";
            // 
            // lblAddrVal
            // 
            lblAddrVal.Font = new Font("Segoe UI", 10F);
            lblAddrVal.ForeColor = Color.FromArgb(30, 40, 80);
            lblAddrVal.Location = new Point(60, 214);
            lblAddrVal.Name = "lblAddrVal";
            lblAddrVal.Size = new Size(370, 44);
            lblAddrVal.TabIndex = 10;
            lblAddrVal.Text = "EX. 123 Wanderlust Tower, MG Road,\nBangalore – 560001, India";
            // 
            // lblHoursIcon
            // 
            lblHoursIcon.AutoSize = true;
            lblHoursIcon.Font = new Font("Segoe UI Emoji", 18F);
            lblHoursIcon.Location = new Point(16, 272);
            lblHoursIcon.Name = "lblHoursIcon";
            lblHoursIcon.Size = new Size(47, 32);
            lblHoursIcon.TabIndex = 11;
            lblHoursIcon.Text = "🕐";
            // 
            // lblHoursLbl
            // 
            lblHoursLbl.AutoSize = true;
            lblHoursLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoursLbl.ForeColor = Color.FromArgb(50, 60, 90);
            lblHoursLbl.Location = new Point(60, 274);
            lblHoursLbl.Name = "lblHoursLbl";
            lblHoursLbl.Size = new Size(90, 15);
            lblHoursLbl.TabIndex = 12;
            lblHoursLbl.Text = "Business Hours";
            // 
            // lblHoursVal
            // 
            lblHoursVal.Font = new Font("Segoe UI", 10F);
            lblHoursVal.ForeColor = Color.FromArgb(30, 40, 80);
            lblHoursVal.Location = new Point(60, 292);
            lblHoursVal.Name = "lblHoursVal";
            lblHoursVal.Size = new Size(370, 44);
            lblHoursVal.TabIndex = 13;
            lblHoursVal.Text = "EX. Monday – Saturday: 9:00 AM – 7:00 PM\nSunday: Closed";
            // 
            // lblSocialTitle
            // 
            lblSocialTitle.AutoSize = true;
            lblSocialTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSocialTitle.ForeColor = Color.FromArgb(50, 60, 90);
            lblSocialTitle.Location = new Point(16, 360);
            lblSocialTitle.Name = "lblSocialTitle";
            lblSocialTitle.Size = new Size(73, 19);
            lblSocialTitle.TabIndex = 14;
            lblSocialTitle.Text = "Follow Us";
            // 
            // btnFacebook
            // 
            btnFacebook.Location = new Point(0, 0);
            btnFacebook.Name = "btnFacebook";
            btnFacebook.Size = new Size(75, 23);
            btnFacebook.TabIndex = 15;
            btnFacebook.Click += btnFacebook_Click;
            // 
            // btnInstagram
            // 
            btnInstagram.Location = new Point(0, 0);
            btnInstagram.Name = "btnInstagram";
            btnInstagram.Size = new Size(75, 23);
            btnInstagram.TabIndex = 16;
            btnInstagram.Click += btnInstagram_Click;
            // 
            // btnTwitter
            // 
            btnTwitter.Location = new Point(0, 0);
            btnTwitter.Name = "btnTwitter";
            btnTwitter.Size = new Size(75, 23);
            btnTwitter.TabIndex = 17;
            btnTwitter.Click += btnTwitter_Click;
            // 
            // btnWhatsApp
            // 
            btnWhatsApp.Location = new Point(0, 0);
            btnWhatsApp.Name = "btnWhatsApp";
            btnWhatsApp.Size = new Size(75, 23);
            btnWhatsApp.TabIndex = 18;
            btnWhatsApp.Click += btnWhatsApp_Click;
            // 
            // Contact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPanel);
            Name = "Contact";
            Size = new Size(1200, 749);
            Load += Contact_Load;
            mainPanel.ResumeLayout(false);
            cardPanel.ResumeLayout(false);
            cardPanel.PerformLayout();
            infoCard.ResumeLayout(false);
            infoCard.PerformLayout();
            ResumeLayout(false);
        }

        private static void SetupSocialButton(System.Windows.Forms.Button btn, string text,
            System.Drawing.Color color, System.Drawing.Point loc, int tabIdx)
        {
            btn.BackColor = color;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = loc;
            btn.Size = new System.Drawing.Size(200, 38);
            btn.Text = text;
            btn.TabIndex = tabIdx;
            btn.UseVisualStyleBackColor = false;
        }

        #endregion
        private System.Windows.Forms.Panel mainPanel, cardPanel, infoCard;

        private System.Windows.Forms.Label lblPageTitle, lblPageSub;
        private System.Windows.Forms.Panel divider;

        private System.Windows.Forms.Label iconName, lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label iconEmail, lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label iconPhone, lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label iconSubject, lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label iconMessage, lblMessage;
        private System.Windows.Forms.RichTextBox txtMessage;

        private System.Windows.Forms.Button btnSend, btnClear, btnBack;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Panel lblInfoDivider;
        private System.Windows.Forms.Label lblPhone1Icon, lblPhone1, lblPhone1Val;
        private System.Windows.Forms.Label lblEmailIcon, lblEmailLbl, lblEmailVal;
        private System.Windows.Forms.Label lblAddrIcon, lblAddrLbl, lblAddrVal;
        private System.Windows.Forms.Label lblHoursIcon, lblHoursLbl, lblHoursVal;
        private System.Windows.Forms.Label lblSocialTitle;
        private System.Windows.Forms.Button btnFacebook, btnInstagram, btnTwitter, btnWhatsApp;
    }
}
