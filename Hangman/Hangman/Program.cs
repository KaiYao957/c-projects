using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!");
            bool gameActive = true;
            do
            {
                Console.WriteLine("Type in the secret word that will serve as the correct answer:");
                Console.ForegroundColor = ConsoleColor.Black; // No peeking!
                Game.Answer = Console.ReadLine().ToUpper();
                Console.ResetColor();
                Game.initializeWord(Game.Answer);
                Game.Lives = 5;
                bool gameOver = false;
                do
                {
                    string outcome = nextRound();
                    switch (outcome)
                    {
                        case "win":
                            Console.WriteLine("Congratulations! You won the game!");
                            gameOver = true;
                            gameActive = playAgain();
                            break;
                        case "lose":
                            Console.WriteLine($"Game over! You lost. The correct answer is: {Game.Answer}. Better luck next time.");
                            gameOver = true;
                            gameActive = playAgain();
                            break;
                        case "quit":
                            Console.WriteLine($"Game over! You just quit the game. The correct answer is: {Game.Answer}.");
                            gameOver = true;
                            gameActive = playAgain();
                            break;
                        default:
                            break;
                    }
                }
                while (!gameOver);
            }
            while (gameActive);
            Console.WriteLine("Thank you for playing Hangman! Have a nice day!");
        }

        // Begins the next round
        static string nextRound()
        {
            Game.displayLivesLeft();
            Console.WriteLine("Current word: " + Game.CurrentWord);
            while(true)
            {
                Console.WriteLine("Choose an action.\n(1) Guess a letter \n(2) Guess the secret word" +
                " \n(3) Display guesses \n(4) Display lives \n(5) Quit");
                try
                { 
                    char action = Convert.ToChar(Console.ReadLine());
                    switch(action)
                    {
                        case '1':
                            Console.WriteLine("Choose a letter to guess.");
                            char l = Convert.ToChar(Console.ReadLine());
                            if(Game.alreadyGuessed(l))
                            {
                                Console.WriteLine($"You already guessed: {l}. Please try again.");
                                continue;
                            }
                            bool correctLetter = Game.guessLetter(l);
                            if(correctLetter)
                            {
                                Console.WriteLine("You guessed the right letter!");
                                Game.fillWord(l);
                                if(Game.CurrentWord == Game.Answer)
                                {
                                    return "win";
                                }
                                else
                                {
                                    return "continue";
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong letter. You lost a life.");
                                Game.Lives--;
                                if (Game.Lives <= 0)
                                {
                                    return "lose";
                                }
                                else
                                {
                                    return "continue";
                                }
                            }
                        case '2':
                            Console.WriteLine("Choose a word to guess.");
                            string w = Console.ReadLine();
                            bool correctAnswer = Game.guessWord(w);
                            if(correctAnswer)
                            {
                                Console.WriteLine("You guessed the correct word!");
                                return "win";
                            }
                            else
                            {
                                Console.WriteLine("Wrong answer. You lost a life.");
                                Game.Lives--;
                                if(Game.Lives <= 0)
                                {
                                    return "lose";
                                }
                                else
                                {
                                    return "continue";
                                }
                            }
                        case '3':
                            Game.displayGuesses();
                            break;
                        case '4':
                            Game.displayLivesLeft();
                            Console.WriteLine($"You have {Game.Lives} lives left.");
                            break;
                        case '5':
                            Console.WriteLine("Are you really sure you want to quit? (Type \"Yes\" to quit, or anything else to keep playing.)");
                            if (Console.ReadLine() == "Yes")
                            {
                                return "quit";
                            }
                            else
                            {
                                break;
                            }
                        default:
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                    }
                }
                catch(FormatException fe)
                {
                    Console.WriteLine("Invalid input. " + fe.Message + " Please try again.");
                }
            }
        }

        // After the game is finished, asks the player if they want to play again
        static bool playAgain()
        {
            Console.WriteLine("Would you like to play again? (Type \"Yes\" to play again, or anything else to quit.)");
            string response = Console.ReadLine();
            if(response.ToUpper() == "YES")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
