namespace traveliti
{
    partial class AddDestinationForm
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
            label1 = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            pictureBox1 = new PictureBox();
            btnAdd = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnUpdate = new Button();
            btnBack = new Button();
            btnDelete = new Button();
            dgvDestination = new DataGridView();
            btnAddImage = new Button();
            hauntedaddbutton = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDestination).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 24;
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(142, 23);
            txtName.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(139, 66);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(142, 23);
            txtDescription.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(139, 105);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(142, 23);
            txtPrice.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(139, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Red;
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(139, 302);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 41);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(123, 19);
            label2.TabIndex = 14;
            label2.Text = "DESCRIPTION:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 109);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 15;
            label3.Text = "PRICE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 183);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 16;
            label4.Text = "IMAGES:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Red;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(139, 444);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 41);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(139, 397);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(142, 41);
            btnBack.TabIndex = 18;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(139, 349);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 41);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvDestination
            // 
            dgvDestination.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDestination.Location = new Point(437, 255);
            dgvDestination.Name = "dgvDestination";
            dgvDestination.Size = new Size(609, 228);
            dgvDestination.TabIndex = 20;
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = Color.Green;
            btnAddImage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddImage.Location = new Point(139, 255);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(142, 41);
            btnAddImage.TabIndex = 21;
            btnAddImage.Text = "Add Images";
            btnAddImage.UseVisualStyleBackColor = false;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // hauntedaddbutton
            // 
            hauntedaddbutton.BackColor = Color.Red;
            hauntedaddbutton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hauntedaddbutton.Location = new Point(139, 491);
            hauntedaddbutton.Name = "hauntedaddbutton";
            hauntedaddbutton.Size = new Size(142, 41);
            hauntedaddbutton.TabIndex = 22;
            hauntedaddbutton.Text = "Haunted ADD";
            hauntedaddbutton.UseVisualStyleBackColor = false;
            hauntedaddbutton.Click += hauntedaddbutton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 23);
            label5.Name = "label5";
            label5.Size = new Size(63, 22);
            label5.TabIndex = 25;
            label5.Text = "Name:";
            // 
            // AddDestinationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 529);
            Controls.Add(label5);
            Controls.Add(hauntedaddbutton);
            Controls.Add(btnAddImage);
            Controls.Add(dgvDestination);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "AddDestinationForm";
            Text = "AddDestinationForm";
            Load += AddDestinationForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDestination).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private PictureBox pictureBox1;
        private Button btnAdd;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnUpdate;
        private Button btnBack;
        private Button btnDelete;
        private DataGridView dgvDestination;
        private Button btnAddImage;
        private Button hauntedaddbutton;
        private Label label5;
    }
}