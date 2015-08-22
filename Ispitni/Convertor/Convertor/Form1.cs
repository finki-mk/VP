using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Convertor
{
    public partial class Form1 : Form
    {
        Convertor current;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblConvertors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblConvertors.SelectedIndex != -1)
            {
                current = lblConvertors.SelectedItem as Convertor;
                lblFrom.Text = current.From;
                lblTo.Text = current.To;
                nudFrom.Value = 1;
                nudTo.Value = nudFrom.Value * current.Multiplier;
            }
            nudFrom.Enabled = lblConvertors.SelectedIndex != -1;
            nudTo.Enabled = lblConvertors.SelectedIndex != -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddConvertor ac = new AddConvertor();
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lblConvertors.Items.Add(ac.Result);
            }
        }

        private void nudFrom_ValueChanged(object sender, EventArgs e)
        {
            nudTo.Value = nudFrom.Value * current.Multiplier;
        }

        private void nudTo_ValueChanged(object sender, EventArgs e)
        {
            nudFrom.Value = nudTo.Value / current.Multiplier;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblConvertors.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни?", "Избриши конвертор?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    lblConvertors.Items.RemoveAt(lblConvertors.SelectedIndex);
                    nudFrom.Value = 0;
                    nudTo.Value = 0;
                    lblFrom.Text = "FROM";
                    lblTo.Text = "TO";
                }
            }
        }
    }
}
