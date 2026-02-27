namespace traveliti
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel6 = new Panel();
            panel1 = new Panel();
            Registerbutton = new Button();
            txtpassword = new TextBox();
            passwordlbel = new Label();
            userlabel = new Label();
            exitbutton = new Button();
            Loginbutton = new Button();
            txtusername = new TextBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.FromArgb(0, 192, 192);
            panel6.BackgroundImage = Properties.Resources.Full_shot_travel_concept_with_landmarks___Premium_AI_generated_image;
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Controls.Add(panel1);
            panel6.Controls.Add(panel3);
            panel6.Location = new Point(-285, -50);
            panel6.Name = "panel6";
            panel6.Size = new Size(1940, 836);
            panel6.TabIndex = 6;
            panel6.Paint += panel6_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.ChatGPT_Image_Feb_23__2026__02_22_57_PM;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(Registerbutton);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(passwordlbel);
            panel1.Controls.Add(userlabel);
            panel1.Controls.Add(exitbutton);
            panel1.Controls.Add(Loginbutton);
            panel1.Controls.Add(txtusername);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(1940, 660);
            panel1.TabIndex = 17;
            // 
            // Registerbutton
            // 
            Registerbutton.BackColor = Color.Green;
            Registerbutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registerbutton.Location = new Point(920, 299);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(127, 40);
            Registerbutton.TabIndex = 7;
            Registerbutton.Text = "REGISTER";
            Registerbutton.UseVisualStyleBackColor = false;
            Registerbutton.Click += Registerbutton_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(951, 253);
            txtpassword.MaxLength = 15;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(148, 23);
            txtpassword.TabIndex = 15;
            // 
            // passwordlbel
            // 
            passwordlbel.AutoSize = true;
            passwordlbel.BackColor = Color.Transparent;
            passwordlbel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordlbel.Location = new Point(855, 254);
            passwordlbel.Name = "passwordlbel";
            passwordlbel.Size = new Size(90, 22);
            passwordlbel.TabIndex = 2;
            passwordlbel.Text = "Password";
            // 
            // userlabel
            // 
            userlabel.AutoSize = true;
            userlabel.BackColor = Color.Transparent;
            userlabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userlabel.Location = new Point(884, 213);
            userlabel.Name = "userlabel";
            userlabel.Size = new Size(58, 22);
            userlabel.TabIndex = 1;
            userlabel.Text = "Email";
            // 
            // exitbutton
            // 
            exitbutton.BackColor = Color.Red;
            exitbutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitbutton.Location = new Point(920, 391);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(127, 39);
            exitbutton.TabIndex = 6;
            exitbutton.Text = "EXIT";
            exitbutton.UseVisualStyleBackColor = false;
            exitbutton.Click += exitbutton_Click;
            // 
            // Loginbutton
            // 
            Loginbutton.BackColor = Color.Green;
            Loginbutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbutton.Location = new Point(920, 345);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(127, 40);
            Loginbutton.TabIndex = 5;
            Loginbutton.Text = "LOGIN";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(951, 212);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(148, 23);
            txtusername.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1940, 176);
            panel3.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.travel;
            pictureBox1.Location = new Point(817, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 735);
            Controls.Add(panel6);
            Name = "LoginPage";
            Text = "Lp";
            Load += LoginPage_Load;
            Resize += LoginPage_Resize;
            panel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Panel panel1;
        private Button Registerbutton;
        private TextBox txtpassword;
        private Label passwordlbel;
        private Label userlabel;
        private Button exitbutton;
        private Button Loginbutton;
        private TextBox txtusername;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}