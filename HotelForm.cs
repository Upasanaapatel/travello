using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace traveliti
{
    public partial class HotelForm : Form
    {
        private string conStr = @"Data Source=localhost\SQLEXPRESS;
                                  Initial Catalog=traveliti;
                                  Integrated Security=True";

        public HotelForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = @"INSERT INTO Hotel 
                                (Name, CityID, Stars, PerNightPrice, Dining) 
                                VALUES 
                                (@Name, @CityID, @Stars, @Price, @Dining)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@CityID", int.Parse(txtCityID.Text));
                cmd.Parameters.AddWithValue("@Stars", int.Parse(txtStars.Text));
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@Dining", chkDining.Checked);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Hotel Inserted Successfully!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "DELETE FROM Hotel WHERE HotelID=@HotelID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@HotelID", int.Parse(txtHotelID.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Hotel Deleted Successfully!");
            }
        }
    }
}

