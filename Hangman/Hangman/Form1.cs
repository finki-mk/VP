using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Објект од класата која ги содржи сите информации за играта.
        /// </summary>
        private HangmanWord hangmanWord;

        private IWordSelector wordSelector;
        /// <summary>
        /// Времетраење на играта во секунди.
        /// </summary>
        private static readonly int TIME = 60 * 10; 
        /// <summary>
        /// Изминато време во секунди.
        /// </summary>
        private int timeElapsed;

        public Form1()
        {
            InitializeComponent();
            wordSelector = new ArrayWordSelector();
            newGame();
        }
        /// <summary>
        /// Метод за стартување на нова игра.
        /// </summary>
        private void newGame()
        {
            hangmanWord = new HangmanWord(wordSelector.pick());
            updateWordMask();
            updateGuessedLetters();
            timeElapsed = 0;
            updateTime();
            timer1.Start();
            pbTime.Maximum = TIME;
            pbTime.Value = TIME;
            pbWrong.Value = hangmanWord.WrongCount;
            pbWrong.Maximum = HangmanWord .MAX_WRONG_COUNT;
            tbLetter.Enabled = true;
            btnOK.Enabled = true;
        }
        /// <summary>
        /// Метод за обновување на содржината на скриениот збор.
        /// </summary>
        private void updateWordMask()
        {
            lblWord.Text = hangmanWord.WordMask();
        }
        
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            enterLetter();
        }
        
        private void enterLetter()
        {
            if (tbLetter.Text.Length > 0)
            {
                char c = tbLetter.Text[0];
                tbLetter.Text = "";
                c = Char.ToLower(c);                
                if (hangmanWord.GuessLetter(c))
                {
                    pbWrong.Value = hangmanWord.WrongCount;
                    updateWordMask();
                    updateGuessedLetters();
                    checkGameState();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            pbTime.Value = TIME - timeElapsed;
            if (timeElapsed == TIME)
            {
                hangmanWord.EndGame();
                tbLetter.Enabled = false;
                btnOK.Enabled = false;
                updateWordMask();
                timer1.Stop();
            }
            updateTime();
        }
        /// <summary>
        /// Метод за обновување на времето.
        /// </summary>
        private void updateTime()
        {
            int left = TIME - timeElapsed;
            int min = left / 60;
            int sec = left % 60;
            lblTimeLeft.Text = string.Format("{0:00}:{1:00}", min, sec);
        }

        private void updateGuessedLetters()
        {
            tbLetters.Text = hangmanWord.GuessedLettersMask();
        }

        private void checkGameState()
        {
            if (hangmanWord.IsGameOver)
            {
                string caption = string.Format("Неуспешно погодување", timeElapsed / 60, timeElapsed % 60);
                hangmanWord.EndGame();
                updateWordMask();
                timer1.Stop();
                tbLetter.Enabled = false;
                btnOK.Enabled = false;
                startNewGame(caption);
                                
            }
            else
            {
                if (hangmanWord.IsGuessed)
                {
                    timer1.Stop();
                    string caption = string.Format("Го погодивте зборот за {0:00}:{1:00}", timeElapsed / 60, timeElapsed % 60);
                    tbLetter.Enabled = false;
                    btnOK.Enabled = false;
                    startNewGame(caption); 
                }
            }
        }

        public void startNewGame(string caption)
        {
            if (MessageBox.Show("Нова игра?", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                newGame();
            }
        }

        private void tbLetter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterLetter();
                e.Handled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
