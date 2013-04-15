using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    /// <summary>
    /// Класа за претставување на состојбата на играта.
    /// </summary>
    public class HangmanWord
    {
        /// <summary>
        /// Зборот што се погодува.
        /// </summary>
        public string Word { get; set; }

        /// <summary>
        /// Сите букви кои се внесени за да се погоди зборот.
        /// </summary>
        public HashSet<char> AllLetters { get; set; }

        /// <summary>
        /// Буквите од кои е составен зборот.
        /// </summary>
        public HashSet<char> WordLetters { get; set; }

        /// <summary>
        /// Број на неуспешни обиди.
        /// </summary>
        public int WrongCount { get; set; }

        /// <summary>
        /// Максимален број на неуспешни обиди
        /// </summary>
        public static readonly int MAX_WRONG_COUNT = 5;

        /// <summary>
        /// Конструктор на нова игра. Го иницијализира зборот и соодветните структури
        /// и ја пополнува структурата со сите букви од кои е составен зборот.
        /// </summary>
        /// <param name="word">Зборот кој треба да се погодува.</param>
        public HangmanWord(string word)
        {
            Word = word;
            WordLetters = new HashSet<char>();
            foreach (char c in Word)
            {
                WordLetters.Add(Char.ToLower(c));
            }
            AllLetters = new HashSet<char>();
            WrongCount = 0;
        }
        /// <summary>
        /// Дали зборот е погоден. При секое погодување на буква од зборот истата се исрфла од
        /// множеството со букви од кои е составен зборот.
        /// </summary>
        public bool IsGuessed
        {
            get
            {
                return WordLetters.Count == 0;
            }
        }
        /// <summary>
        /// Дали е крај на играта, односно дали бројот на неуспешни обиди го достигнал
        /// максималниот број на неуспешни обиди.
        /// </summary>
        public bool IsGameOver
        {
            get
            {
                return WrongCount == MAX_WRONG_COUNT;
            }
        }

        /// <summary>
        /// Се повикува кога се обидуваме да погодиме буква од зборот.
        /// </summary>
        /// <param name="letter">Буквата која ја погодуваме.</param>
        /// <returns>Дали буквата е претходно искористена.</returns>
        public bool GuessLetter(char letter)
        {
            if (AllLetters.Contains(letter))
            {
                return false;
            }
            AllLetters.Add(letter);
            if (WordLetters.Contains(letter))
            {
                WordLetters.Remove(letter);
            }
            else
            {
                WrongCount++;
            }
            return true;
        }
        /// <summary>
        /// Стринг за приказ на зборот. Секоја не погодена буква се заменува со "_" и
        /// се додава празно место помеѓу буквите.
        /// </summary>
        /// <returns>Стрингот за приказ.</returns>
        public string WordMask()
        {
            StringBuilder guess = new StringBuilder();
            for (int i = 0; i < Word.Length; i++)
            {
                char c = Word[i];
                c = Char.ToLower(c);
                if (WordLetters.Contains(c))
                {
                    guess.Append("_");
                }
                else
                {
                    guess.Append(Word[i]);
                }
                if (i != Word.Length - 1)
                    guess.Append(" ");
            }
            return guess.ToString();
        }
        /// <summary>
        /// Стринг со сите букви кои се искористени.
        /// </summary>
        /// <returns>Стрингот за приказ.</returns>
        public string GuessedLettersMask()
        {
            StringBuilder res = new StringBuilder();
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (AllLetters.Contains(c))
                {
                    res.Append(Char.ToUpper(c));
                }
                else
                {
                    res.Append("_");
                }
                res.Append(" ");
            }
            return res.ToString();
        }

        public void EndGame()
        {
            WordLetters.Clear();
        }
    }
}
