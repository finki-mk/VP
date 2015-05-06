using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zadaca1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Production m = new Production("AMC", "01");
            cbProductions.Items.Add(m);
            m = new Production("Showtime", "02");
            cbProductions.Items.Add(m);
            m = new Production("HBO", "03");
            cbProductions.Items.Add(m);
        }

        private void btnAddAuto_Click(object sender, EventArgs e)
        {
            Series series = new Series();
            series.Production = cbProductions.SelectedItem as Production;
            series.Name = tbName.Text;
            series.Rating = (double)nudRating.Value;
            series.Seasons = (int)nudSeasons.Value;
            lbSeries.Items.Add(series);
            cbProductions.SelectedIndex = -1;
            tbName.Clear();
            nudSeasons.Value = 0;
            nudSeasons.ResetText();
            nudRating.Value = 5;
            nudRating.ResetText();
            calculate();
        }

        private void calculate()
        {
            if (lbSeries.Items.Count > 0)
            {
                Series most = lbSeries.Items[0] as Series;
                double sum = most.Rating;
                for (int i = 1; i < lbSeries.Items.Count; i++)
                {
                    Series a = lbSeries.Items[i] as Series;
                    if (a.Seasons < most.Seasons)
                    {
                        most = a;
                    }
                    sum += a.Rating;
                }
                tbRatingAverage.Text = string.Format("{0:0.0}", sum / lbSeries.Items.Count);
                tbMostSeasons.Text = most.ToString();
            }
            else
            {
                tbRatingAverage.Clear();
                tbMostSeasons.Clear();
            }
            
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (lbSeries.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да ја избришете оваа серија?", "Потврда за бришење?", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    lbSeries.Items.RemoveAt(lbSeries.SelectedIndex);
                    calculate();
                }                
            }
        }

        private void btnAddProduction_Click(object sender, EventArgs e)
        {
            NewProduction form = new NewProduction();
            form.Form1 = this;
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cbProductions.Items.Add(form.Production);                
            }
        }

        private void lbSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = lbSeries.SelectedIndex != -1;
        }

        public bool existsProduction(string code)
        {
            for (int i = 0; i < cbProductions.Items.Count; ++i)
            {
                Production m = cbProductions.Items[i] as Production;
                if (m.Code == code)
                {
                    return true;
                }
            }
            return false;
        }

        private void cbProductions_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddSeries.Enabled = cbProductions.SelectedIndex != -1 && tbName.Text.Trim().Length > 0;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            btnAddSeries.Enabled = cbProductions.SelectedIndex != -1 && tbName.Text.Trim().Length > 0;
        }
    }
}
