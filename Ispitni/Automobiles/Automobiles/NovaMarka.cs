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
    public partial class NovaMarka : Form
    {
        public Marka Marka { get; set; }

        public NovaMarka()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Marka = new Zadaca1.Marka();
            Marka.Ime = tbIme.Text;
            Marka.Sifra = tbSifra.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbIme, "Името е задолжително");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
                e.Cancel = false;
            }
        }

        private void tbSifra_Validating(object sender, CancelEventArgs e)
        {
            if (tbSifra.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbSifra, "Шифрата е задолжителна");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbSifra, null);
                e.Cancel = false;
            }
        }
    }
}
