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
            int pizzaPercentage = GetPizzaPercentage();
            int pastaPercentage = GetPastaPercentage();
            int papAndWorsPercentage = GetPapAndWorsPercentage();
            int eatOutRatingAverage = GetAverageRatingEatOut();
            int watchMoviesRatingAverage = GetAverageRatingWatchMovies();
            int watchTVRatingAverage = GetAverageRatingWatchTV();
            int listenToRadioRatingAverage = GetAverageRatingListenToRadio();

            // Update the UI with the survey results
            lblTotalSurveys.Text =  totalSurveys.ToString();
            lblAverageAge.Text = averageAge.ToString("F1");
            lblMaxAge.Text =  maxAge.ToString();
            lblMinAge.Text =  minAge.ToString();
          lblPizzaPercentage.Text =  pizzaPercentage.ToString("F1") + "%";
            lblPastaPercentage.Text =  pastaPercentage.ToString("F1") + "%";
           lblPapAndWorsPercentage.Text =  papAndWorsPercentage.ToString("F1") + "%";
            lblEatOutRating.Text =  eatOutRatingAverage.ToString("F1");
            lblWatchMoviesRating.Text =  watchMoviesRatingAverage.ToString("F1");
            lblWatchTVRating.Text =  watchTVRatingAverage.ToString("F1");
            lblListenToRadioRating.Text =  listenToRadioRatingAverage.ToString("F1");
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

        private int GetPizzaPercentage()
        {
            double pizzaPercentage = 0;

            // Perform database query to calculate the percentage of people who like Pizza
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT (SUM(CAST(Pizza AS INT)) * 100.0 / COUNT(*)) FROM SurveyData", connection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    pizzaPercentage = Convert.ToInt32(result);
                }
            }

            return (int)pizzaPercentage;
        }

        private int GetPastaPercentage()
        {
            double pastaPercentage = 0;

            // Perform database query to calculate the percentage of people who like Pasta
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT (SUM(CAST(Pasta AS INT)) * 100.0 / COUNT(*)) FROM SurveyData", connection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    pastaPercentage = Convert.ToInt32(result);
                }
            }

            return (int)pastaPercentage;
        }

        private int GetPapAndWorsPercentage()
        {
            double papAndWorsPercentage = 0;

            // Perform database query to calculate the percentage of people who like Pap and Wors
            using (SqlConnection connection = new SqlConnection("Data Source=desktop-rrr0012;Initial Catalog=SurveyApp;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT (SUM(CAST(PapAndWors AS INT)) * 100.0 / COUNT(*)) FROM SurveyData", connection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    papAndWorsPercentage = Convert.ToDouble(result);
                }
            }

            return (int)papAndWorsPercentage;
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
