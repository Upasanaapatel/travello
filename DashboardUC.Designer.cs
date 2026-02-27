namespace traveliti
{
    partial class DashboardUC
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
            components = new System.ComponentModel.Container();
            fontDialog1 = new FontDialog();
            notifyIcon1 = new NotifyIcon(components);
            helpProvider1 = new HelpProvider();
            folderBrowserDialog1 = new FolderBrowserDialog();
            bindingSource1 = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            toppanel = new Panel();
            labelTagline = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            backbutton = new Button();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // toppanel
            // 
            toppanel.BackColor = Color.White;
            toppanel.Controls.Add(labelTagline);
            toppanel.Controls.Add(label3);
            toppanel.Controls.Add(label1);
            toppanel.Controls.Add(pictureBox1);
            toppanel.Controls.Add(panel2);
            toppanel.Dock = DockStyle.Top;
            toppanel.ImeMode = ImeMode.Katakana;
            toppanel.Location = new Point(0, 0);
            toppanel.Name = "toppanel";
            toppanel.Size = new Size(1370, 64);
            toppanel.TabIndex = 2;
            toppanel.UseWaitCursor = true;
            // 
            // labelTagline
            // 
            labelTagline.AutoSize = true;
            labelTagline.ForeColor = Color.Navy;
            labelTagline.Location = new Point(132, 41);
            labelTagline.Name = "labelTagline";
            labelTagline.Size = new Size(148, 15);
            labelTagline.TabIndex = 4;
            labelTagline.Text = "Your Perfect Escape Awaits";
            labelTagline.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 36);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            label3.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.MenuBar;
            label1.AllowDrop = true;
            label1.AutoEllipsis = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(102, 9);
            label1.Name = "label1";
            label1.Size = new Size(304, 42);
            label1.TabIndex = 2;
            label1.Text = "Travel Itinerary";
            label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.travel;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(96, 100);
            panel2.TabIndex = 0;
            panel2.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(backbutton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1274, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(96, 533);
            panel1.TabIndex = 5;
            // 
            // backbutton
            // 
            backbutton.BackColor = Color.Red;
            backbutton.Dock = DockStyle.Bottom;
            backbutton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbutton.Location = new Point(0, 494);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(96, 39);
            backbutton.TabIndex = 5;
            backbutton.Text = "🔁 Back";
            backbutton.UseVisualStyleBackColor = false;
            backbutton.Click += backbutton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(1274, 533);
            panel3.TabIndex = 6;
            // 
            // DashboardUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 597);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(toppanel);
            KeyPreview = true;
            Name = "DashboardUC";
            Text = "DashboardUC";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            toppanel.ResumeLayout(false);
            toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FontDialog fontDialog1;
        private NotifyIcon notifyIcon1;
        private HelpProvider helpProvider1;
        private FolderBrowserDialog folderBrowserDialog1;
        private BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel toppanel;
        private Label labelTagline;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
        private Button backbutton;
        private Panel panel3;
    }
}