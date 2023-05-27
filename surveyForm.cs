using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Survey
{
    public partial class surveyForm : Form
    {
        public surveyForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void surveyForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get user input data
            string surname = txtSurname.Text;
            string firstNames = txtFirstNames.Text;
            //
            //DateTime date = dtPicker.Value;
            //

            // Get selected food options
            bool pizza = checkPizza.Checked;
            bool pasta = checkPasta.Checked;
            bool papAndWors = checkPapAndWors.Checked;
            bool chickenStirFry = checkChicken.Checked;
            bool beefStirFry = checkBeef.Checked;
            bool other = checkOther.Checked;

            // Get selected ratings
            int EatOutRating = GetRatingValue(cmbEatOut.SelectedIndex + 1);
            int WatchMoviesRating = GetRatingValue(cmbWatchMovies.SelectedIndex + 1);
            int WatchTVRating = GetRatingValue(cmbWatchTV.SelectedIndex + 1);
            int ListenToRadioRating = GetRatingValue(cmbListenToRadio.SelectedIndex + 1);
            string contactNumberText = txtContactNumber.Text;
            if (string.IsNullOrWhiteSpace(txtSurname.Text) || string.IsNullOrWhiteSpace(txtFirstNames.Text) )
            {
                MessageBox.Show("Please fill in all the required fields.");
               
            }

          
            // Check if the input string is empty
            if (string.IsNullOrEmpty(contactNumberText))
            {
                MessageBox.Show("Contact number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Attempt to convert the input string to an integer
            if (!int.TryParse(contactNumberText, out int contactNumber))
            {
                MessageBox.Show("Invalid contact number. Please enter a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Validate the age field
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Age is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 5 || age > 120)
            {
                MessageBox.Show("Invalid age. Please enter a valid integer between 5 and 120.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if a rating is selected for each question
            if (cmbEatOut.SelectedIndex == -1 || cmbWatchMovies.SelectedIndex == -1 || cmbWatchTV.SelectedIndex == -1 || cmbListenToRadio.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a rating for each question.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Save survey data to the database

            con.Open();
            SqlCommand com = new SqlCommand("INSERT INTO SurveyData VALUES('" + txtSurname.Text + "','" + txtFirstNames.Text + "','" + txtContactNumber.Text + "','" + dtPicker.Value + "'," +
                "'" + txtAge.Text + "','" + EatOutRating + "','" + WatchMoviesRating + "','" + WatchTVRating + "','" + ListenToRadioRating + "','" + pizza + "','" + pasta + "','" + papAndWors + "','" + chickenStirFry + "','" + beefStirFry + "','" + other + "')", con);
            
            
            
            
            
            com.ExecuteNonQuery();
            MessageBox.Show("Survey data inserted successfully!");

            // Return to Screen 1
            Home hForm = new Home();
            hForm.Show();
            this.Close();

        }
        private int GetRatingValue(int ratingIndex)
        {
            // Add 1 to the rating index to get the corresponding value
            return ratingIndex;
        }
        

    }
}
