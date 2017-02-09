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
    public partial class NewDay : Form
    {
        public Daily Day { get; set; }

        public NewDay()
        {
            InitializeComponent();
            foreach (string month in Daily.MONTHS)
            {
                cbMonth.Items.Add(month);
            }
            for (int i = 1; i <= 31; ++i)
            {
                cbDay.Items.Add(i);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Day = new Daily();
            Day.Day = (int)cbDay.SelectedItem;
            Day.Month = cbMonth.SelectedIndex;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
