namespace traveliti
{
    partial class AIChatbot
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;

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
            rtbChat = new RichTextBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            panelMain = new Panel();
            SuspendLayout();
            // 
            // rtbChat
            // 
            rtbChat.Location = new Point(12, 12);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(560, 350);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 375);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(460, 23);
            txtMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(490, 373);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(82, 27);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(600, 154);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(200, 100);
            panelMain.TabIndex = 3;
            // 
            // AIChatbot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 411);
            Controls.Add(panelMain);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(rtbChat);
            Name = "AIChatbot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Travel AI Chatbot";
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelMain;
    }
}