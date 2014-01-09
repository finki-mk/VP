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
        }

        private void btnAddMarka_Click(object sender, EventArgs e)
        {
            NovaMarka novaMarka = new NovaMarka();
            if (novaMarka.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbMarki.Items.Add(novaMarka.Marka);
                dodadiMarki();
            }
        }

        private void dodadiMarki()
        {
            cbMarka.Items.Clear();
            for (int i = 0; i < lbMarki.Items.Count; i++)
            {
                Marka m = (Marka)lbMarki.Items[i];
                cbMarka.Items.Add(m);
            }
        }

        private void btnAddAuto_Click(object sender, EventArgs e)
        {
            if (cbMarka.SelectedIndex == -1)
            {
                MessageBox.Show("Изберете марка");
                return;
            }
            if (tbModel.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Внесете модел");
                return;
            }
            Avtomobil avto = new Avtomobil();
            avto.Marka = cbMarka.SelectedItem as Marka;
            avto.Model = tbModel.Text;
            avto.Potrosuvacka = (double)nudPotrosuvacka.Value;
            avto.Cena = (int)nudCena.Value;
            lbAutos.Items.Add(avto);
            cbMarka.SelectedIndex = -1;
            tbModel.Clear();
            nudCena.Value = 0;
            nudCena.ResetText();
            nudPotrosuvacka.Value = 0;
            nudPotrosuvacka.ResetText();
            presmetaj();
        }

        private void presmetaj()
        {
            if (lbAutos.Items.Count > 0)
            {
                Avtomobil najekonomicen = lbAutos.Items[0] as Avtomobil;
                Avtomobil najskap = lbAutos.Items[0] as Avtomobil;
                double sum = najekonomicen.Potrosuvacka;
                for (int i = 1; i < lbAutos.Items.Count; i++)
                {
                    Avtomobil a = lbAutos.Items[i] as Avtomobil;
                    if (a.Potrosuvacka < najekonomicen.Potrosuvacka)
                    {
                        najekonomicen = a;
                    }
                    if (a.Cena > najskap.Cena)
                    {
                        najskap = a;
                    }
                    sum += a.Potrosuvacka;
                }
                tbProsek.Text = string.Format("{0:0.0}", sum / lbAutos.Items.Count);
                tbNajekonomicen.Text = najekonomicen.ToString();
                tbNajskap.Text = najskap.ToString();
            }
            else
            {
                tbProsek.Clear();
                tbNajekonomicen.Clear();
                tbNajskap.Clear();
            }
            
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (lbAutos.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете овој автомобил?", "Потврда за бришење?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    lbAutos.Items.RemoveAt(lbAutos.SelectedIndex);
                    presmetaj();
                }                
            }
        }
    }
}
