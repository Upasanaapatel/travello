using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace traveliti
{
    public partial class DestinationDetail : Form
    {
        private List<PictureBox> imageBoxes;
        private int _destinationId;
        private string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        // ── These fields now get populated in LoadDestinationDetails() ──
        private string _name = "Unknown Destination";
        private string _description = string.Empty;
        private decimal _price = 0;

        // DEFAULT CONSTRUCTOR
        public DestinationDetail()
        {
            InitializeComponent();
            InitializeImageBoxes();
            this.KeyPreview = true;
            this.KeyDown += DestinationDetail_KeyDown;
        }

        // PARAMETERIZED CONSTRUCTOR
        public DestinationDetail(int destinationId)
        {
            InitializeComponent();
            InitializeImageBoxes();
            this.KeyPreview = true;
            this.KeyDown += DestinationDetail_KeyDown;
            _destinationId = destinationId;
            LoadImages();
        }

        // FORM LOAD
        private void DestinationDetail_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            if (_destinationId > 0)
                LoadDestinationDetails();
        }

        // INITIALIZE IMAGE BOXES
        private void InitializeImageBoxes()
        {
            imageBoxes = new List<PictureBox>()
            {
                pictureBox1,
                pictureBoxseven,
                pictureBoxthree,
                pictureBoxsix,
                pictureBoxone,
                pictureBoxtwo,
                pictureBoxfive,
                pictureBoxfour,
                pictureBoxten,
                pictureBoxtwelve,
                pictureBoxthirteen,
                pictureBoxsixteen,
                pictureBoxfourteen,
                pictureBoxeleven,
                pictureBoxfifteen,
            };

            foreach (PictureBox pb in imageBoxes)
            {
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.Image = null;
                pb.Tag = null;
            }
        }

        // LOAD DESTINATION DETAILS — now stores data into _name, _description, _price
        private void LoadDestinationDetails()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = @"SELECT Name, Description, Price
                                 FROM AddDestinations
                                 WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", _destinationId);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // ✅ Store into private fields so Generate Itinerary can use them
                    _name = dr["Name"].ToString();
                    _description = dr["Description"].ToString();
                    _price = Convert.ToDecimal(dr["Price"]);

                    // Update UI labels as before
                    lblPlace.Text = _name;
                    lblDays.Text = _description;
                    lblPrice.Text = "₹ " + _price.ToString("N0");
                    lblHotel.Text = "";
                }
            }
        }

        // LOAD IMAGES FROM DATABASE
        private void LoadImages()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT ImageData FROM DestinationImag WHERE DestinationId = @did", con);

                cmd.Parameters.AddWithValue("@did", _destinationId);

                SqlDataReader reader = cmd.ExecuteReader();

                int index = 0;

                while (reader.Read() && index < imageBoxes.Count)
                {
                    byte[] imgBytes = (byte[])reader["ImageData"];

                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        imageBoxes[index].Image = Image.FromStream(ms);
                    }

                    index++;
                }
            }
        }

        // ADD IMAGE BUTTON
        private void addimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int index = 0;

                for (int i = 0; i < imageBoxes.Count; i++)
                {
                    if (imageBoxes[i].Image == null)
                    {
                        index = i;
                        break;
                    }
                }

                foreach (string file in ofd.FileNames)
                {
                    if (index >= imageBoxes.Count)
                        break;

                    try
                    {
                        if (imageBoxes[index].Image != null)
                        {
                            imageBoxes[index].Image.Dispose();
                            imageBoxes[index].Image = null;
                        }

                        imageBoxes[index].Image = new Bitmap(file);
                        index++;
                    }
                    catch
                    {
                        MessageBox.Show("Unsupported image format.");
                    }
                }
            }
        }

        // SUBMIT BUTTON - SAVE IMAGES TO DATABASE
        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (_destinationId <= 0)
            {
                MessageBox.Show("Invalid destination");
                return;
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                foreach (PictureBox pb in imageBoxes)
                {
                    if (pb.Image == null)
                        continue;

                    try
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            Bitmap bmp = new Bitmap(pb.Image);
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                            byte[] imgBytes = ms.ToArray();

                            SqlCommand cmd = new SqlCommand(
                                "INSERT INTO DestinationImag (DestinationId, ImageData) VALUES (@did, @img)", con);

                            cmd.Parameters.AddWithValue("@did", _destinationId);
                            cmd.Parameters.AddWithValue("@img", imgBytes);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving image: " + ex.Message);
                    }
                }
            }

            MessageBox.Show("Images saved successfully");
        }

        // BACK BUTTON
        private void btnBack_Click(object sender, EventArgs e)
        {
            Popular p = new Popular();
            p.Show();
            this.Close();
        }

        // EMPTY EVENTS (UNCHANGED)
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void pictureBox5_Click(object sender, EventArgs e) { }

        private void txtPlaceName_TextChanged(object sender, EventArgs e)
        {
            label2.Text = txtPlaceName.Text;
        }

        private void DestinationDetail_Resize(object sender, EventArgs e) { }
        private void lblPlace_Click(object sender, EventArgs e) { }
        private void backbutton_Click(object sender, EventArgs e) { }
        private void pictureBoxsixteen_Click(object sender, EventArgs e) { }
        private void DestinationDetail_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) { }
        private void DestinationDetail_KeyPress(object sender, KeyPressEventArgs e) { }

        // ESC key → go back to Popular
        private void DestinationDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Popular p = new Popular();
                p.Show();
                this.Hide();
                e.Handled = true;
            }
        }

        // ✅ GENERATE ITINERARY BUTTON — now passes real destination data
        private void genitibtn_Click(object sender, EventArgs e)
        {
            // Make sure details are loaded before opening
            if (_destinationId > 0 && string.IsNullOrEmpty(_name) || _name == "Unknown Destination")
                LoadDestinationDetails();

            GenerateItineraryForm itinerary = new GenerateItineraryForm(
                _destinationId,   // ✅ correct field (was: destinationId — always 0)
                _name,            // ✅ correct field (was: name — always null)
                _description,     // ✅ correct field (was: description — always null)
                _price            // ✅ correct field (was: price — always 0)
            );
            itinerary.Show();
            this.Hide();
        }
    }
}