using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountriesList
{
    public partial class Form1 : Form
    {
        private int totalQuestions;
        private int correctAnswers;
        private List<Country> selectedCountries;
        private Country correctCountry;

        public Form1()
        {
            InitializeComponent();
            Country c = new Country("Macedonia", "Skopje", "MK");
            lbCountries.Items.Add(c);
            lbCountries.Items.Add(new Country("USA", "Washington", "US"));
            c = new Country("France", "Paris", "FR");
            lbCountries.Items.Add(c);
            lbCountries.Items.Add(new Country("Russia", "Moskow", "RU"));
            lbCountries.Items.Add(new Country("Italy", "Rome", "IT"));
            totalQuestions = 0;
            correctAnswers = 0;
            selectedCountries = new List<Country>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbCode.Text.Trim().Length > 0 &&
                tbCaptial.Text.Trim().Length > 0 &&
                tbName.Text.Trim().Length > 0)
            {
                Country c = new Country(tbName.Text.Trim(), tbCaptial.Text.Trim(),
                    tbCode.Text.Trim());
                lbCountries.Items.Add(c);
                tbName.Clear();
                tbCaptial.Clear();
                tbCode.Clear();

            }
            else
            {
                MessageBox.Show("All fields should not be empty!");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbCountries.SelectedIndex != -1)
            {
                lbCountries.Items.RemoveAt(lbCountries.SelectedIndex);
            }
        }

        private void lbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country c = lbCountries.SelectedItem as Country;
            if (c != null)
            {
                tbName.Text = c.Name;
                tbCode.Text = c.Code;
                tbCaptial.Text = c.Capital;
            }
        }

        void chooseRandomCountry(Random random)
        {
            int r = random.Next(lbCountries.Items.Count);
            Country c = lbCountries.Items[r] as Country;
            bool exist = false;
            foreach (Country cc in selectedCountries)
            {
                if (cc.Name.Equals(c.Name))
                {
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                selectedCountries.Add(c);
            }
            else
            {
                chooseRandomCountry(random);
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            selectedCountries.Clear();
            Random r = new Random();
            // Choose three random countries
            for (int i = 0; i < 3; ++i)
            {
                chooseRandomCountry(r);
            }
            rbC1.Text = selectedCountries[0].Capital;
            rbC2.Text = selectedCountries[1].Capital;
            rbC3.Text = selectedCountries[2].Capital;
            // Choose the correct country
            int correct = r.Next(3);
            correctCountry = selectedCountries[correct];
            lblQuestion.Text = string.Format("The capital of {0} is?", correctCountry.Name);

        }

        private void rbC1_CheckedChanged(object sender, EventArgs e)
        {
            btnGuess.Enabled = true;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string answer = "";
            if (rbC1.Checked)
            {
                answer = rbC1.Text;
            }
            if (rbC2.Checked)
            {
                answer = rbC2.Text;
            }
            if (rbC3.Checked)
            {
                answer = rbC3.Text;
            }
            if(answer.Equals(correctCountry.Capital))
            {
                correctAnswers++;
            }
            totalQuestions++;
            lblPoints.Text = string.Format("{0}/{1}", correctAnswers, totalQuestions);

        }


    }
}
