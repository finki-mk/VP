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
            Team t1 = new Team("Барселона", "Шпанија");
            Team t2 = new Team("Реал Мадрид", "Шпанија");
            Team t3 = new Team("Манчестер Ј.", "Англија");
            Team t4 = new Team("Арсенал", "Англија");
            Team t5 = new Team("Милан", "Италија");
            Team t6 = new Team("Бенфика", "Португалија");
            lbTeams.Items.Add(t1);
            lbTeams.Items.Add(t2);
            lbTeams.Items.Add(t3);
            lbTeams.Items.Add(t4);
            lbTeams.Items.Add(t5);
            lbTeams.Items.Add(t6);
        }

        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {
            AddTeamForm addTeamForm = new AddTeamForm();
            if (addTeamForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbTeams.Items.Add(addTeamForm.Team);
            }
        }

        bool containsTeam(Game game)
        {
            for (int i = 0; i < lbGames.Items.Count; i++)
            {
                Game g = lbGames.Items[i] as Game;
                if (g.Code.Equals(game.Code))
                {
                    return true;
                }
            }
            return false;
        }
        private void btnAddToGames_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }
            if (lbTeams.SelectedItems.Count == 2)
            {
                Game game = new Game();
                game.Code = mtbCode.Text;
                game.HomeTeam = lbTeams.SelectedItems[0] as Team;
                game.GuestTeam = (Team)lbTeams.SelectedItems[1];
                game.Coefitients[0] = (float)nudCoef1.Value;
                game.Coefitients[1] = (float)nudCoefX.Value;
                game.Coefitients[2] = (float)nudCoef2.Value;
                if (!containsTeam(game))
                {
                    lbGames.Items.Add(game);
                    nudCoef1.ResetText();
                    nudCoefX.ResetText();
                    nudCoef2.ResetText();
                    lbTeams.ClearSelected();
                    mtbCode.Clear();
                }
                else
                {
                    MessageBox.Show("Овој натпревар е веќе внесен!");
                }
            }
            else
            {
                MessageBox.Show("Избери точно 2 тима!");
            }
        }

        private void mtbCode_Validating(object sender, CancelEventArgs e)
        {
            if (!mtbCode.MaskCompleted)
            {
                e.Cancel = true;
                errorProvider1.SetError(mtbCode, "Внесете четири цифри!");
            }
            else
            {
                errorProvider1.SetError(mtbCode, null);
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            if (lbGames.SelectedIndex != -1 && cbTip.SelectedIndex != -1)
            {
                Game game = (Game)lbGames.SelectedItem;
                TicketItem ti = new TicketItem();
                ti.Game = game;
                ti.Tip = cbTip.SelectedIndex;
                if (!containsTicketItem(ti))
                {
                    lbTickets.Items.Add(ti);
                    lbGames.ClearSelected();
                    calculateTotal();
                }
                else
                {
                    MessageBox.Show("Овој наптревар е веќе типуван!");
                }
                
            }
        }

        bool containsTicketItem(TicketItem ti)
        {
            foreach (object obj in lbTickets.Items)
            {
                TicketItem ticketItem = obj as TicketItem;
                if (ti.Game.Code.Equals(ticketItem.Game.Code))
                {
                    return true;
                }
            }
            return false;
        }

        void calculateTotal()
        {
            float totalCoef = 1;
            for (int i = 0; i < lbTickets.Items.Count; ++i)
            {
                TicketItem ti = lbTickets.Items[i] as TicketItem;
                totalCoef *= ti.Game.Coefitients[ti.Tip];
            }
            tbTotalCoef.Text = string.Format("{0:0.000}", totalCoef);
            tbProfit.Text = string.Format("{0:0.0}", totalCoef * (float)nudPayment.Value);
        }

        private void nudPayment_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("За вложени {0:0.0} добивката е {1}", nudPayment.Value, tbProfit.Text));
        }

        private void tbCodeToEnter_TextChanged(object sender, EventArgs e)
        {

        }

    
     
    }
}
