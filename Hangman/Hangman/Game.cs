using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    static class Game
    {
        /*
         * This is a static class that represents information for the Hangman game,
         * and contains the game's basic functionality.
         */

        private static int maxLives = 5;
        private static List<char> guesses = new List<char>(); // holds all the letters guessed by the player
        public static int Lives
        {
            get;
            set;
        }
        public static string Answer
        {
            get;
            set;
        }
        public static string CurrentWord
        {
            get;
            private set;
        }

        // Initializes the current word with underscores at the beginning of the game.
        public static void initializeWord(string answer)
        {
            CurrentWord = "";
            guesses.Clear();
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == ' ' || answer[i] == ':' || answer[i] == ',' || answer[i] == '\'')
                {
                    CurrentWord += answer[i];
                }
                else
                {
                    CurrentWord += '_';
                }
            }
        }

        // Checks if the letter is in the answer.
        public static bool guessLetter(char letter)
        {
            guesses.Add(char.ToUpper(letter));
            return Answer.Contains(char.ToUpper(letter));
        }

        // Fills in all of the spaces of the current word that match the answer.
        public static void fillWord(char letter)
        {
            string wordToFill = "";
            for(int i=0; i<Answer.Length; i++)
            {
                if(Answer[i] == char.ToUpper(letter))
                {
                    wordToFill += char.ToUpper(letter);
                }
                else
                {
                    wordToFill += CurrentWord[i];
                }
            }
            CurrentWord = wordToFill;
        }

        // Checks if the guessed word is the correct answer.
        public static bool guessWord(string guess)
        {
            return Answer == guess.ToUpper();
        }

        // Checks if the letter has already been guessed.
        public static bool alreadyGuessed(char letter)
        {
            return guesses.Contains(char.ToUpper(letter));
        }

        /*
         * Displays the current word,
         * as well as all the letters already guessed by the player.
         */
        public static void displayGuesses()
        {
            Console.WriteLine("Current word: "+CurrentWord);
            Console.Write("Letters guessed: | ");
            foreach(char letter in guesses)
            {
                Console.Write(letter + " ");
            }
            Console.Write("| \n");
        }

        /*
         * Displays the life counter with 'O's and 'X's.
         * Each O represents lives still remaining.
         * Each X represents lives lost.
         */
        public static void displayLivesLeft()
        {
            string livesLeft = "";
            for(int i=0; i<maxLives; i++)
            {
                if(i<Lives)
                { 
                    livesLeft += "O";
                }
                else
                {
                    livesLeft += "X";
                }
            }
            Console.WriteLine("Lives left: "+livesLeft);
        }
    }
}
