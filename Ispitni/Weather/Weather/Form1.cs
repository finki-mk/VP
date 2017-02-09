using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form1 : Form
    {
        Daily selectedDaily;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddDay_Click(object sender, EventArgs e)
        {
            NewDay newDay = new NewDay();
            if (newDay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbDays.Items.Add(newDay.Day);
                findMinAndMax();
            }
        }

        private void lbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDaily = lbDays.SelectedItem as Daily;
            if (selectedDaily != null)
            {
                lblDate.Text = selectedDaily.Date;
                nudMin.Value = selectedDaily.Min;
                nudMax.Value = selectedDaily.Max;
            }
            else
            {
                lblDate.Text = "";
                nudMax.ResetText();
                nudMin.ResetText();
            }
        }

        private void nudMin_Validating(object sender, CancelEventArgs e)
        {
            if (nudMin.Value > nudMax.Value)
            {
                errorProvider1.SetError(nudMin, "Минималната температура треба да биде помала од максималната");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudMin, null);
            }
        }

        private void nudMin_ValueChanged(object sender, EventArgs e)
        {
            if (selectedDaily != null)
            {
                selectedDaily.Min = (int)nudMin.Value;
                findMinAndMax();
            }
        }

        private void nudMax_ValueChanged(object sender, EventArgs e)
        {
            if (selectedDaily != null)
            {
                selectedDaily.Max = (int)nudMax.Value;
                findMinAndMax();
            }
        }

        private void nudMax_Validating(object sender, CancelEventArgs e)
        {
            if (nudMax.Value < nudMin.Value)
            {
                errorProvider1.SetError(nudMax, "Максималната температура треба да биде поголема од минималната");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudMax, null);
            }
        }

        void findMinAndMax()
        {
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            Daily minDaily = null;
            Daily maxDaily = null;
            foreach (object obj in lbDays.Items)
            {
                Daily daily = obj as Daily;
                if (daily.Max > max)
                {
                    max = daily.Max;
                    maxDaily = daily;
                }
                if (daily.Min < min)
                {
                    min = daily.Min;
                    minDaily = daily;
                }
            }
            if (maxDaily != null)
            {
                lblMax.Text = maxDaily.ToString();
                lblMin.Text = minDaily.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedDaily != null)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете овој ден?", "Потврди бришење?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    lbDays.Items.Remove(selectedDaily);
                    findMinAndMax();
                }
            }
        }
    }
}
