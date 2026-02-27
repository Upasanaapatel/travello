namespace traveliti
{
    partial class HotelForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHotelID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCityID;
        private System.Windows.Forms.Label lblStars;
        private System.Windows.Forms.Label lblPrice;

        private System.Windows.Forms.TextBox txtHotelID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCityID;
        private System.Windows.Forms.TextBox txtStars;
        private System.Windows.Forms.TextBox txtPrice;

        private System.Windows.Forms.CheckBox chkDining;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblHotelID = new Label();
            lblName = new Label();
            lblCityID = new Label();
            lblStars = new Label();
            lblPrice = new Label();
            txtHotelID = new TextBox();
            txtName = new TextBox();
            txtCityID = new TextBox();
            txtStars = new TextBox();
            txtPrice = new TextBox();
            chkDining = new CheckBox();
            btnInsert = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblHotelID
            // 
            lblHotelID.AutoSize = true;
            lblHotelID.Location = new Point(30, 28);
            lblHotelID.Name = "lblHotelID";
            lblHotelID.Size = new Size(50, 15);
            lblHotelID.TabIndex = 0;
            lblHotelID.Text = "Hotel ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 68);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblCityID
            // 
            lblCityID.AutoSize = true;
            lblCityID.Location = new Point(30, 108);
            lblCityID.Name = "lblCityID";
            lblCityID.Size = new Size(42, 15);
            lblCityID.TabIndex = 2;
            lblCityID.Text = "City ID";
            // 
            // lblStars
            // 
            lblStars.AutoSize = true;
            lblStars.Location = new Point(30, 148);
            lblStars.Name = "lblStars";
            lblStars.Size = new Size(32, 15);
            lblStars.TabIndex = 3;
            lblStars.Text = "Stars";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(30, 188);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(86, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Per Night Price";
            // 
            // txtHotelID
            // 
            txtHotelID.Location = new Point(150, 20);
            txtHotelID.Name = "txtHotelID";
            txtHotelID.Size = new Size(150, 23);
            txtHotelID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 23);
            txtName.TabIndex = 6;
            // 
            // txtCityID
            // 
            txtCityID.Location = new Point(150, 100);
            txtCityID.Name = "txtCityID";
            txtCityID.Size = new Size(150, 23);
            txtCityID.TabIndex = 7;
            // 
            // txtStars
            // 
            txtStars.Location = new Point(150, 140);
            txtStars.Name = "txtStars";
            txtStars.Size = new Size(150, 23);
            txtStars.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(150, 180);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 23);
            txtPrice.TabIndex = 9;
            // 
            // chkDining
            // 
            chkDining.AutoSize = true;
            chkDining.Location = new Point(150, 220);
            chkDining.Name = "chkDining";
            chkDining.Size = new Size(112, 19);
            chkDining.TabIndex = 10;
            chkDining.Text = "Dining Available";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(70, 260);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(100, 35);
            btnInsert.TabIndex = 11;
            btnInsert.Text = "Insert";
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 260);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // HotelForm
            // 
            ClientSize = new Size(835, 574);
            Controls.Add(lblHotelID);
            Controls.Add(lblName);
            Controls.Add(lblCityID);
            Controls.Add(lblStars);
            Controls.Add(lblPrice);
            Controls.Add(txtHotelID);
            Controls.Add(txtName);
            Controls.Add(txtCityID);
            Controls.Add(txtStars);
            Controls.Add(txtPrice);
            Controls.Add(chkDining);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Name = "HotelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Management";
            PerformLayout();
        }
    }
}
