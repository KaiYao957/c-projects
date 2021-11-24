using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    static class Game
    {
        static string name;
        static int luck = 5;
        static Random rng = new Random();

        public static int Points {get; set;}
        public static void startGame()
        {
            Console.WriteLine("Welcome to my adventure game.");
            Console.WriteLine("It's time to explore the world and do something.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Right now, please type in your name: ");
            nameCharacter();
        }

        public static void nameCharacter()
        {
            string name = Console.ReadLine();
            // If user does not enter a name, this default name will be assigned.
            if (String.IsNullOrEmpty(name))
            {
                name = "Random unnamed person";
            }
            Console.WriteLine($"Welcome, {name}!");
        }

        public static bool Lucky()
        {
            int roll = rng.Next(10);
            if(roll <= luck)
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
