namespace Food_Survey
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblListenToRadioRating = new System.Windows.Forms.Label();
            this.lblWatchTVRating = new System.Windows.Forms.Label();
            this.lblWatchMoviesRating = new System.Windows.Forms.Label();
            this.lblEatOutRating = new System.Windows.Forms.Label();
            this.lblPapAndWorsPercentage = new System.Windows.Forms.Label();
            this.lblPastaPercentage = new System.Windows.Forms.Label();
            this.lblPizzaPercentage = new System.Windows.Forms.Label();
            this.lblMinAge = new System.Windows.Forms.Label();
            this.lblMaxAge = new System.Windows.Forms.Label();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.lblTotalSurveys = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "The results of the survey";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 31);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total number of surveys: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Average age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Oldest person who participated in survey";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Youngest person who participated in survey ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Percentage of people who like Pizza:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Percentage of people who like Pasta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(354, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Percentage of people who like Pap and Wors:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "People like to eat out:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "People like to watch movies: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 424);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "People like to watch TV:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 452);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(254, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "People like to listen to the radio:";
            // 
            // lblListenToRadioRating
            // 
            this.lblListenToRadioRating.AutoSize = true;
            this.lblListenToRadioRating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblListenToRadioRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListenToRadioRating.Location = new System.Drawing.Point(457, 452);
            this.lblListenToRadioRating.Name = "lblListenToRadioRating";
            this.lblListenToRadioRating.Size = new System.Drawing.Size(63, 20);
            this.lblListenToRadioRating.TabIndex = 24;
            this.lblListenToRadioRating.Text = "label15";
            // 
            // lblWatchTVRating
            // 
            this.lblWatchTVRating.AutoSize = true;
            this.lblWatchTVRating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWatchTVRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchTVRating.Location = new System.Drawing.Point(457, 424);
            this.lblWatchTVRating.Name = "lblWatchTVRating";
            this.lblWatchTVRating.Size = new System.Drawing.Size(63, 20);
            this.lblWatchTVRating.TabIndex = 23;
            this.lblWatchTVRating.Text = "label16";
            // 
            // lblWatchMoviesRating
            // 
            this.lblWatchMoviesRating.AutoSize = true;
            this.lblWatchMoviesRating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWatchMoviesRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchMoviesRating.Location = new System.Drawing.Point(457, 397);
            this.lblWatchMoviesRating.Name = "lblWatchMoviesRating";
            this.lblWatchMoviesRating.Size = new System.Drawing.Size(63, 20);
            this.lblWatchMoviesRating.TabIndex = 22;
            this.lblWatchMoviesRating.Text = "label17";
            // 
            // lblEatOutRating
            // 
            this.lblEatOutRating.AutoSize = true;
            this.lblEatOutRating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEatOutRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEatOutRating.Location = new System.Drawing.Point(457, 369);
            this.lblEatOutRating.Name = "lblEatOutRating";
            this.lblEatOutRating.Size = new System.Drawing.Size(63, 20);
            this.lblEatOutRating.TabIndex = 21;
            this.lblEatOutRating.Text = "label18";
            // 
            // lblPapAndWorsPercentage
            // 
            this.lblPapAndWorsPercentage.AutoSize = true;
            this.lblPapAndWorsPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPapAndWorsPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPapAndWorsPercentage.Location = new System.Drawing.Point(457, 290);
            this.lblPapAndWorsPercentage.Name = "lblPapAndWorsPercentage";
            this.lblPapAndWorsPercentage.Size = new System.Drawing.Size(63, 20);
            this.lblPapAndWorsPercentage.TabIndex = 20;
            this.lblPapAndWorsPercentage.Text = "label19";
            // 
            // lblPastaPercentage
            // 
            this.lblPastaPercentage.AutoSize = true;
            this.lblPastaPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPastaPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastaPercentage.Location = new System.Drawing.Point(457, 264);
            this.lblPastaPercentage.Name = "lblPastaPercentage";
            this.lblPastaPercentage.Size = new System.Drawing.Size(63, 20);
            this.lblPastaPercentage.TabIndex = 19;
            this.lblPastaPercentage.Text = "label20";
            // 
            // lblPizzaPercentage
            // 
            this.lblPizzaPercentage.AutoSize = true;
            this.lblPizzaPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPizzaPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaPercentage.Location = new System.Drawing.Point(457, 238);
            this.lblPizzaPercentage.Name = "lblPizzaPercentage";
            this.lblPizzaPercentage.Size = new System.Drawing.Size(63, 20);
            this.lblPizzaPercentage.TabIndex = 18;
            this.lblPizzaPercentage.Text = "label21";
            // 
            // lblMinAge
            // 
            this.lblMinAge.AutoSize = true;
            this.lblMinAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMinAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinAge.Location = new System.Drawing.Point(457, 161);
            this.lblMinAge.Name = "lblMinAge";
            this.lblMinAge.Size = new System.Drawing.Size(63, 20);
            this.lblMinAge.TabIndex = 17;
            this.lblMinAge.Text = "label22";
            // 
            // lblMaxAge
            // 
            this.lblMaxAge.AutoSize = true;
            this.lblMaxAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAge.Location = new System.Drawing.Point(457, 127);
            this.lblMaxAge.Name = "lblMaxAge";
            this.lblMaxAge.Size = new System.Drawing.Size(63, 20);
            this.lblMaxAge.TabIndex = 16;
            this.lblMaxAge.Text = "label23";
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAge.Location = new System.Drawing.Point(457, 96);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(63, 20);
            this.lblAverageAge.TabIndex = 15;
            this.lblAverageAge.Text = "label24";
            // 
            // lblTotalSurveys
            // 
            this.lblTotalSurveys.AutoSize = true;
            this.lblTotalSurveys.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSurveys.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSurveys.Location = new System.Drawing.Point(457, 64);
            this.lblTotalSurveys.Name = "lblTotalSurveys";
            this.lblTotalSurveys.Size = new System.Drawing.Size(63, 20);
            this.lblTotalSurveys.TabIndex = 14;
            this.lblTotalSurveys.Text = "label25";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-2, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 33);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(-2, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 33);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(-2, 482);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(607, 33);
            this.panel4.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 28;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblListenToRadioRating);
            this.Controls.Add(this.lblWatchTVRating);
            this.Controls.Add(this.lblWatchMoviesRating);
            this.Controls.Add(this.lblEatOutRating);
            this.Controls.Add(this.lblPapAndWorsPercentage);
            this.Controls.Add(this.lblPastaPercentage);
            this.Controls.Add(this.lblPizzaPercentage);
            this.Controls.Add(this.lblMinAge);
            this.Controls.Add(this.lblMaxAge);
            this.Controls.Add(this.lblAverageAge);
            this.Controls.Add(this.lblTotalSurveys);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblListenToRadioRating;
        private System.Windows.Forms.Label lblWatchTVRating;
        private System.Windows.Forms.Label lblWatchMoviesRating;
        private System.Windows.Forms.Label lblEatOutRating;
        private System.Windows.Forms.Label lblPapAndWorsPercentage;
        private System.Windows.Forms.Label lblPastaPercentage;
        private System.Windows.Forms.Label lblPizzaPercentage;
        private System.Windows.Forms.Label lblMinAge;
        private System.Windows.Forms.Label lblMaxAge;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Label lblTotalSurveys;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
    }
}