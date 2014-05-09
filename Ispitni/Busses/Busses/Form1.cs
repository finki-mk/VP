using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Busses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bus bus = new Bus("5463", "ЈСП 5", true);
            bus.AddDestination(new Line("Аеродром", 12, 5, 35));
            lbBussues.Items.Add(bus);
            loadLines();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewBus newBus = new NewBus();
            if (newBus.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbBussues.Items.Add(newBus.Bus);
            }
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteBuss.Enabled = lbBussues.SelectedIndex != -1;
            btnAddLine.Enabled = lbBussues.SelectedIndex != -1;
            loadLines();
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            AddLine form = new AddLine();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bus airport = lbBussues.SelectedItem as Bus;
                airport.AddDestination(form.Line);
                loadLines();
            }
        }

        void loadLines()
        {
            lbLines.Items.Clear();
            tbAverage.Clear();
            tbMostExpensive.Clear();
            Bus bus = lbBussues.SelectedItem as Bus;
            if (bus != null && bus.Lines.Count > 0)
            {
                Line maxPrice = bus.Lines[0];
                float totalPrice = 0;
                foreach (Line line in bus.Lines)
                {
                    lbLines.Items.Add(line);
                    if (line.Price > maxPrice.Price)
                    {
                        maxPrice = line;
                    }
                    totalPrice += line.Price;
                }
                tbAverage.Text = string.Format("{0:#.0}", totalPrice / lbLines.Items.Count);
                tbMostExpensive.Text = maxPrice.ToString();
            }
            
        }

        private void btnDeleteDestination_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете автобусот?", "Избриши автобус", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                lbBussues.Items.RemoveAt(lbBussues.SelectedIndex);
                loadLines();
            }
        }
       
    }
}
