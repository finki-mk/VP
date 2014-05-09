using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Airports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Airport airport = new Airport("Александар Велики", "Скопје", "SKP");
            airport.AddDestination(new Destination("Виена", 1240, 260));
            lbAirports.Items.Add(airport);
            loadDestinations();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewAirport newAirport = new NewAirport();
            if (newAirport.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbAirports.Items.Add(newAirport.Airport);
            }
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteDestination.Enabled = lbAirports.SelectedIndex != -1;
            btnAddDestination.Enabled = lbAirports.SelectedIndex != -1;
            loadDestinations();
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            AddDestination form = new AddDestination();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Airport airport = lbAirports.SelectedItem as Airport;
                airport.AddDestination(form.Destination);
                loadDestinations();
            }
        }

        void loadDestinations()
        {
            lbDestinations.Items.Clear();
            tbAverage.Clear();
            tbLongest.Clear();
            Airport airport = lbAirports.SelectedItem as Airport;
            if (airport != null && airport.Destinations.Count > 0)
            {
                Destination maxPrice = airport.Destinations[0];
                float totalDistance = 0;
                foreach (Destination destination in airport.Destinations)
                {
                    lbDestinations.Items.Add(destination);
                    if (destination.Price > maxPrice.Price)
                    {
                        maxPrice = destination;
                    }
                    totalDistance += destination.Distance;
                }
                tbAverage.Text = string.Format("{0:#.0}", totalDistance / lbDestinations.Items.Count);
                tbLongest.Text = maxPrice.ToString();
            }
            
        }

        private void btnDeleteDestination_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете аеродромот?", "Избриши аеродром", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                lbAirports.Items.RemoveAt(lbAirports.SelectedIndex);
                loadDestinations();
            }
        }
       
    }
}
