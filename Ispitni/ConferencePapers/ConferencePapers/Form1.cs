using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConferencePapers
{
    public partial class Form1 : Form
    {
        List<Conference> Conferences;
        Conference selectedConference;
        int selectedYear;
        public Form1()
        {
            InitializeComponent();
            Conferences = new List<Conference>();
            Conference c = new Conference("ICT Innovation", 2014);
            Conferences.Add(c);
            c = new Conference("ICT Innovation", 2013);
            Conferences.Add(c);
            c = new Conference("ADBIS", 2014);
            Conferences.Add(c);
            c = new Conference("CIIT", 2013);
            Conferences.Add(c);
            c = new Conference("CIIT", 2012);
            Conferences.Add(c);            
            selectedYear = -1;
            loadConferences(selectedYear);
            loadYears();
        }

        private void btnAddConference_Click(object sender, EventArgs e)
        {
            ConferenceForm cf = new ConferenceForm();
            if (cf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Conferences.Add(cf.Conference);
                loadConferences(selectedYear);
                loadYears();
            }
        }

        private void loadConferences(int year)
        {
            lbConferences.Items.Clear();
            foreach (Conference c in Conferences)
            {
                if (year == -1 || c.Year == year)
                {
                    lbConferences.Items.Add(c);
                }
            }
        }


        private void loadYears()
        {
            cbYears.Items.Clear();
            cbYears.Items.Add(-1);
            foreach(Conference c in Conferences)
            {                
                if (!cbYears.Items.Contains(c.Year))
                {
                    cbYears.Items.Add(c.Year);
                }
            }
        }

        private void cbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedYear = (int)cbYears.SelectedItem;
            loadConferences(selectedYear);
        }


        private void lbConferences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbConferences.SelectedIndex != -1)
            {
                selectedConference = lbConferences.SelectedItem as Conference;
            }
            else
            {
                selectedConference = null;
            }
        }

        private void btnDeleteConference_Click(object sender, EventArgs e)
        {
            if (lbConferences.SelectedIndex == -1) return;
            if (MessageBox.Show("Дали сте сигурни?", "Избриши конференција?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                List<Conference> filtered = new List<Conference>();
                foreach (Conference c in Conferences)
                {
                    if (c.Id != selectedConference.Id)
                    {
                        filtered.Add(c);
                    }
                }
                Conferences = filtered;
                loadConferences(selectedYear);
            }
        }
    }
}
