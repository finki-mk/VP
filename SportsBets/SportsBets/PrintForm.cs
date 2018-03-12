using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SportsBets
{
    public partial class PrintForm : Form
    {
        public List<Ticket> tickets { get; set; }
        public string dobivka { get; set; }
        public string koeficient { get; set; }
        public string uplata { get; set; }
        public string danok { get; set; }
        public PrintForm()
        {
            InitializeComponent();
        }
        public void init()
        {
                lblCoef.Text = koeficient;
                lblDanok.Text = danok;
                lblDobivka.Text = dobivka;
                lblUplata.Text = uplata;
                foreach (var item in tickets)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridTicket.Rows[0].Clone();
                    row.Cells[0].Value = item.game.Code;
                    row.Cells[1].Value = item.ToString();
                    row.Cells[2].Value = item.game.Coeffietients[item.tip];
                    dataGridTicket.Rows.Add(row);
                }
            }
           

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
    }
}
