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
            TV m = new TV("SK1", 1);
            cbTVS.Items.Add(m);
            m = new TV("24Вести", 2);
            cbTVS.Items.Add(m);
            m = new TV("HBO", 3);
            cbTVS.Items.Add(m);
        }

        private void btnAddAuto_Click(object sender, EventArgs e)
        {
            TVProgram program = new TVProgram();
            TV tv = cbTVS.SelectedItem as TV;
            program.Name = tbName.Text;
            program.Duration = (int)nudDuration.Value;
            tv.Program.Add(program);
            fillList();
            tbName.Clear();
            nudDuration.Value = 30;
            calculate();
        }

        private void calculate()
        {
            if (lbProgram.Items.Count > 0)
            {
                double sum = 0;
                for (int i = 0; i < lbProgram.Items.Count; i++)
                {
                    TVProgram a = lbProgram.Items[i] as TVProgram;
                    sum += a.Duration;
                }
                tbAverage.Text = string.Format("{0:0.0}", sum / lbProgram.Items.Count);
            }
            else
            {
                tbAverage.Clear();
            }
            
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (lbProgram.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да ја избришете оваа програма?", "Потврда за бришење?", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    TV tv = cbTVS.SelectedItem as TV;
                    tv.Program.RemoveAt(lbProgram.SelectedIndex);
                    fillList();
                }                
            }
        }

        private void btnAddProduction_Click(object sender, EventArgs e)
        {
            NewTV form = new NewTV();
            form.Form1 = this;
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cbTVS.Items.Add(form.TV);                
            }
        }

        private void lbSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = lbProgram.SelectedIndex != -1;
        }

        public bool existsProduction(int number)
        {
            for (int i = 0; i < cbTVS.Items.Count; ++i)
            {
                TV m = cbTVS.Items[i] as TV;
                if (m.Number == number)
                {
                    return true;
                }
            }
            return false;
        }

        private void cbProductions_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddProgram.Enabled = cbTVS.SelectedIndex != -1 && tbName.Text.Trim().Length > 0;
            fillList();
        }

        void fillList()
        {
            if (cbTVS.SelectedIndex != -1)
            {
                lbProgram.Items.Clear();
                TV tv = cbTVS.SelectedItem as TV;
                lblTV.Text = tv.Name;
                foreach (TVProgram p in tv.Program)
                {
                    lbProgram.Items.Add(p);
                }
                calculate();
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            btnAddProgram.Enabled = cbTVS.SelectedIndex != -1 && tbName.Text.Trim().Length > 0;
        }
    }
}
