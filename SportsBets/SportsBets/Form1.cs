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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAddToGames_Click(object sender, EventArgs e)
        {
            if (lbTeams.SelectedItems.Count != 2)
            {
                MessageBox.Show("Изберете точно два тима");
            }
            else
            {
                Game game = new Game();
                game.Home = (Team)lbTeams.SelectedItems[0];
                game.Away = (Team)lbTeams.SelectedItems[1];
                game.Coeffietients[0] = nudCoef1.Value;
                game.Coeffietients[1] = nudCoefX.Value;
                game.Coeffietients[2] = nudCoef2.Value;
                game.Code = mtbCode.Text;
                lbGames.Items.Add(game);
                lbTeams.SelectedItems.Clear();
            }

        }

        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {
            TeamForm form = new TeamForm();
            DialogResult result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                lbTeams.Items.Add(form.Team);
            }
        }
        void recalculateCoefficients()
        {
            decimal totalCoeff = 1;
            foreach (Ticket t in lbTickets.Items)
            {
                Game game = t.game;
                decimal localCoef = game.Coeffietients[t.tip];
                totalCoeff *= localCoef;
            }

            tbTotalCoef.Text = totalCoeff.ToString(".00");
            tbProfit.Text = (nudPayment.Value * totalCoeff).ToString(".00");
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            if (cbTip.SelectedIndex == -1)
            {
                MessageBox.Show("Внесете валиден тип");
                return;
            }
            if (tbCodeToEnter.Text != "")
            {
                Game temp = null;
                foreach (var game in lbGames.Items)
                {
                    if (((Game)game).Code == tbCodeToEnter.Text)
                        temp = ((Game)game);
                }
                if (temp == null)
                {
                    MessageBox.Show("Внесете валиден код");
                    return;
                }

                Ticket ticket = new Ticket();
                ticket.game = temp;
                ticket.tip = cbTip.SelectedIndex;
                lbTickets.Items.Add(ticket);
                lbGames.SelectedItems.Clear();
            }
            else if(lbGames.SelectedItem!=null) {
                Ticket ticket = new Ticket();
                ticket.game = (Game)lbGames.SelectedItem;
                ticket.tip = cbTip.SelectedIndex;
                lbTickets.Items.Add(ticket);
                lbGames.SelectedItems.Clear();
            }
            else {
                MessageBox.Show("Внесете шифра или изберете натпревар од листата!");
            }
            recalculateCoefficients();
        }

        private void nudPayment_ValueChanged(object sender, EventArgs e)
        {
            recalculateCoefficients();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintForm p = new PrintForm();
                List<Ticket> tickets = new List<Ticket>();
                foreach (var item in lbTickets.Items)
                {
                    tickets.Add((Ticket)item);
                }
                p.tickets = tickets;
                p.dobivka = tbProfit.Text;
                p.koeficient = tbTotalCoef.Text;
                p.uplata = nudPayment.Value.ToString();
                p.danok = ((decimal.Parse(tbProfit.Text)) * 0.10m).ToString(".00");
                p.init();
                p.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нема натпревари");
            }
        }

        private void nudPayment_KeyUp(object sender, KeyEventArgs e)
        {
            recalculateCoefficients();
        }
    }
}
