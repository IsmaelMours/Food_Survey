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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            // Perform calculations and display the results
            int totalSurveys = GetTotalSurveys();
            int averageAge = GetAverageAge();
            int maxAge = GetMaxAge();
            int minAge = GetMinAge();
            decimal pizzaPercentage = GetPizzaPercentage();
            decimal pastaPercentage = GetPastaPercentage();
            decimal papAndWorsPercentage = GetPapAndWorsPercentage();
            int eatOutRatingAverage = GetAverageRatingEatOut();
            int watchMoviesRatingAverage = GetAverageRatingWatchMovies();
            int watchTVRatingAverage = GetAverageRatingWatchTV();
            int listenToRadioRatingAverage = GetAverageRatingListenToRadio();

            // Update the UI with the survey results
            lblTotalSurveys.Text =  totalSurveys.ToString();
            lblAverageAge.Text = averageAge.ToString();
            lblMaxAge.Text =  maxAge.ToString();
            lblMinAge.Text =  minAge.ToString();
          lblPizzaPercentage.Text =  pizzaPercentage.ToString("F1") + "%";
            lblPastaPercentage.Text =  pastaPercentage.ToString("F1") + "%";
           lblPapAndWorsPercentage.Text =  papAndWorsPercentage.ToString("F1") + "%";
            lblEatOutRating.Text =  eatOutRatingAverage.ToString();
            lblWatchMoviesRating.Text =  watchMoviesRatingAverage.ToString();
            lblWatchTVRating.Text =  watchTVRatingAverage.ToString();
            lblListenToRadioRating.Text =  listenToRadioRatingAverage.ToString();
        }
        private int GetTotalSurveys()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM SurveyData", connection);
                int totalSurveys = (int)command.ExecuteScalar();

                return totalSurveys;
            }
        }

        private int GetAverageAge()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT AVG(Age) FROM SurveyData", connection);
                int averageAge = (int)command.ExecuteScalar();

                return averageAge;
            }
        }

        private int GetMaxAge()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT MAX(Age) FROM SurveyData", connection);
                int maxAge = (int)command.ExecuteScalar();

                return maxAge;
            }
        }

        private int GetMinAge()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT MIN(Age) FROM SurveyData", connection);
                int minAge = (int)command.ExecuteScalar();

                return minAge;
            }
        }

        private decimal GetPizzaPercentage()
        {
            decimal pizzaPercentage = 0;

            // Perform database query to calculate the percentage of people who like Pizza
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ROUND((SUM(CAST(Pizza AS DECIMAL)) * 100.0 / COUNT(*)), 1) FROM SurveyData", connection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    pizzaPercentage = Convert.ToDecimal(result);
                }
            }

            return pizzaPercentage;
        }


        private decimal GetPastaPercentage()
        {
            decimal pastaPercentage = 0;

            // Perform database query to calculate the percentage of people who like Pasta
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ROUND((SUM(CAST(Pasta AS DECIMAL)) * 100.0 / COUNT(*)), 1) FROM SurveyData", connection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    pastaPercentage = Convert.ToDecimal(result);
                }
            }

            return pastaPercentage;
        }

        private decimal GetPapAndWorsPercentage()
        {
            decimal papAndWorsPercentage = 0;

            // Perform database query to calculate the percentage of people who like Pap and Wors
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ROUND((SUM(CAST(PapAndWors AS DECIMAL)) * 100.0 / COUNT(*)), 1) FROM SurveyData", connection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    papAndWorsPercentage = Convert.ToDecimal(result);
                }
            }

            return papAndWorsPercentage;
        }


        private int GetAverageRatingEatOut()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT AVG(EatOutRating) FROM SurveyData", connection);
                int averageRating = (int)command.ExecuteScalar();

                return averageRating;
            }
        }
        private int GetAverageRatingWatchMovies()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT AVG(WatchMoviesRating) FROM SurveyData", connection);
                int averageRating = (int)command.ExecuteScalar();

                return averageRating;
            }
        }

        private int GetAverageRatingWatchTV()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT AVG(WatchTVRating) FROM SurveyData", connection);
                int averageRating = (int)command.ExecuteScalar();

                return averageRating;
            }
        }
        private int GetAverageRatingListenToRadio()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT AVG(ListenToRadioRating) FROM SurveyData", connection);
                int averageRating = (int)command.ExecuteScalar();

                return averageRating;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Return to Screen 1
            Home hForm = new Home();
            hForm.Show();
            this.Close();
        }
    }
}
