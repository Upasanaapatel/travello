using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace traveliti
{
    public partial class AddDestinationForm : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public AddDestinationForm()
        {
            InitializeComponent();
            this.KeyPreview = true;                  // form receives key events first
            this.KeyDown += AddDestinationForm_KeyDown;
        }

        // ── ESC key → go back to Popular ────────────────────────────────
        private void AddDestinationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GoToPopular();
                e.Handled = true;
            }
        }

        // ── Shared navigation helper ─────────────────────────────────────
        private void GoToPopular()
        {
            Popular pop = new Popular();
            pop.Show();
            this.Hide();          // hide this form (don't close, in case you need to return)
        }

        private void AddDestinationForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // LOAD GRID
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT Id, Name, Description, Price, ImagePath FROM AddDestinations", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDestination.DataSource = dt;
            }
        }

        // ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = @"INSERT INTO AddDestinations
                                (Name, Description, Price, ImagePath)
                                VALUES (@Name, @Description, @Price, @ImagePath)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@ImagePath", pictureBox1.ImageLocation ?? "");

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Destination Added Successfully!");
            LoadData();
        }

        // GRID CLICK
        private void dgvDestination_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDestination.CurrentRow != null)
            {
                txtName.Text = dgvDestination.CurrentRow.Cells["Name"].Value.ToString();
                txtDescription.Text = dgvDestination.CurrentRow.Cells["Description"].Value.ToString();
                txtPrice.Text = dgvDestination.CurrentRow.Cells["Price"].Value.ToString();
            }
        }

        // UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDestination.CurrentRow == null)
            {
                MessageBox.Show("Please select a destination to update.");
                return;
            }

            int id = Convert.ToInt32(dgvDestination.CurrentRow.Cells["Id"].Value);

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = @"UPDATE AddDestinations
                                 SET Name=@Name,
                                     Description=@Description,
                                     Price=@Price,
                                     ImagePath=@ImagePath
                                 WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@ImagePath", pictureBox1.ImageLocation ?? "");
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Destination Updated Successfully!");
            LoadData();
        }

        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDestination.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvDestination.CurrentRow.Cells["Id"].Value);

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "DELETE FROM AddDestinations WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Deleted Successfully!");
            LoadData();
        }

        // ADD IMAGE
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        // BACK BUTTON — fixed (was calling Close() on the new form immediately)
        private void btnBack_Click(object sender, EventArgs e)
        {
            GoToPopular();
        }

        // HAUNTED ADD
        private void hauntedaddbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "INSERT INTO HauntedPlaces (Name, Description, Price, Location) " +
                               "VALUES (@Name, @Desc, @Price, @Location)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@Location", txtName.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Haunted Place Added Successfully!");
            }
        }
    }
}