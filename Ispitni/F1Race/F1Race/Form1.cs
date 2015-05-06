using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F1Race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            AddDriver f = new AddDriver();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbDrivers.Items.Add(f.Result);
            }
        }

        private void lbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddLap.Enabled = lbDrivers.SelectedIndex != -1;
            btnDeleteDriver.Enabled = lbDrivers.SelectedIndex != -1;
            showLaps();
        }

        private void btnAddLap_Click(object sender, EventArgs e)
        {
            Lap lap = new Lap();
            lap.Minutes = (int)nudMinutes.Value;
            lap.Seconds = (int)nudSeconds.Value;
            Driver driver = lbDrivers.SelectedItem as Driver;
            driver.Laps.Add(lap);
            nudMinutes.Value = 0;
            nudSeconds.Value = 0;
            showLaps();
        }

        void showLaps()
        {
            Driver driver = lbDrivers.SelectedItem as Driver;
            lbLaps.Items.Clear();
            if (driver != null && driver.Laps.Count > 0)
            {
                int limit = (int)nudLimit.Value;
                Lap best = driver.Laps[0];
                foreach (Lap lap in driver.Laps)
                {
                    if (limit > 0)
                    {
                        if (lap.Time > limit)
                        {
                            lbLaps.Items.Add(lap);
                        }
                    }
                    else
                    {
                        lbLaps.Items.Add(lap);
                    }
                    if (lap.Time < best.Time)
                    {
                        best = lap;
                    }
                }
                tbBestLap.Text = best.ToString();
            }
            else
            {
                tbBestLap.Clear();
            }
        }

        private void nudLimit_ValueChanged(object sender, EventArgs e)
        {
            showLaps();
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Избриши возач?", "Дали сте сигурни?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                lbDrivers.Items.RemoveAt(lbDrivers.SelectedIndex);
                
            }
        }

        private void nudSeconds_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)nudSeconds.Value;
            if (value < 0)
            {
                int min = (int)nudMinutes.Value;
                if (min > 0)
                {
                    nudMinutes.Value = min - 1;
                    nudSeconds.Value = 59;
                }
                else
                {
                    nudSeconds.Value = 0;
                }
                
            }
            else
            {
                nudSeconds.Value = value % 60;
                nudMinutes.Value += value / 60;
            }
        }
    }
}
