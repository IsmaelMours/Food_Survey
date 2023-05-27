using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Survey
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            surveyForm sForm = new surveyForm ()
            ;
            sForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultForm rForm = new ResultForm() ;
            rForm.Show();
            this.Hide();
        }
    }
}
