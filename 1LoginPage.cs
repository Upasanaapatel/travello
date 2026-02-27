using System;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;


namespace traveliti
{
    public partial class LoginPage : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public LoginPage()
        {
            InitializeComponent();
        }

        // REGISTER BUTTON
        private void Registerbutton_Click(object sender, EventArgs e)
        {
            panel6.Controls.Clear();
            Register reg = new Register();
            reg.Dock = DockStyle.Fill;
            panel6.Controls.Add(reg);
            panel6.BringToFront();
        }

        private void Reg_RegisterCompleted(object sender, EventArgs e)
        {
            panel6.Controls.Clear();
            panel6.SendToBack();
        }

        // LOGIN BUTTON
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = @"SELECT Id, Name 
                                 FROM Users 
                                 WHERE Email = @Email AND Password = @Password";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", txtusername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text.Trim());

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    UserSession.UserId = Convert.ToInt32(reader["Id"]);
                    UserSession.Username = reader["Name"].ToString();

                    MessageBox.Show("Login Successful");

                    MainHomePage home = new MainHomePage();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password");
                }
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void panel6_Paint(object sender, EventArgs e)
        {

        }
        private void LoginPage_Resize(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
