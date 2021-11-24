using System;
using System.Collections.Generic;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Game.startGame();
            Console.WriteLine($"You have {Game.Points} points.");
            for (int a = 0; a < 50; a++)
            {
                if (Game.Lucky())
                {
                    Console.WriteLine("Your lucky day! You just gained 1 point.");
                    Game.Points++;
                }
                else
                {
                    Console.WriteLine("Aww, too bad. You lost 1 point.");
                    if (Game.Points > 0)
                        Game.Points--;
                }
            }
            Console.WriteLine($"You have {Game.Points} points. \n What would you like to spend them on?" +
                $"\n A key (A): 3 points \n A coin (B): 5 points \n Both of them (C): 7 points");

            List<Item> inventory = new List<Item>();
            Item key = new Item(0);
            Item coin = new Item(1);
            Item ring = new Item(2);
            Item sandwich = new Item(3);
            Item coffee = new Item(4);
            Item document = new Item(5);
            Item book = new Item(6);
            Item stickers = new Item(7);
            Item pencil = new Item(8);

            switch (Console.ReadLine())
            {
                case "a":
                case "A":
                    if (Game.Points >= 3)
                    {
                        inventory.Add(key);
                        Game.Points -= 3;
                    }
                    else
                        Console.WriteLine("Insufficient points.");
                    break;
                case "b":
                case "B":
                    if (Game.Points >= 5)
                    {
                        inventory.Add(coin);
                        Game.Points -= 5;
                    }
                    else
                        Console.WriteLine("Insufficient points.");
                    break;
                case "c":
                case "C":
                    if (Game.Points >= 7)
                    {
                        inventory.Add(key);
                        inventory.Add(coin);
                        Game.Points -= 7;
                    }
                    else
                        Console.WriteLine("Insufficient points.");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

            Console.WriteLine($"You have {Game.Points} points.");

            if (inventory.Contains(key) && inventory.Contains(coin))
            {
                Console.WriteLine("You have both items.");
            }
            else if (inventory.Contains(key) ^ inventory.Contains(coin))
            {
                Console.WriteLine("You have either of these items, but not both.");
            }
            else
            {
                Console.WriteLine("You don't have any of these items.");
            }

            Console.WriteLine("Where you like to go to next?\n(A) Cafe\n(B) School");
            string location = "Unknown";
            string[] decision1 = {"Cafe", "School"};
            string[] decision2 = {"Go ahead", "Use key", "Use coin"};
            bool[] decision3 = { true, false };
            switch (Console.ReadLine())
            {
                case "a":
                case "A":
                    Console.WriteLine("You went to the cafe. What a good place to have something to eat!");
                    location = decision1[0];
                    break;
                case "b":
                case "B":
                    Console.WriteLine("You went to the school. What a good place to learn something new!");
                    location = decision1[1];
                    break;
                default:
                    Console.WriteLine("Invalid location.");
                    break;
            }

            Console.WriteLine("You currently have:");
            foreach(Item i in inventory)
            {
                Console.WriteLine(i.name);
                i.Describe();
            }

            if(location == decision1[0])
            {
                Console.WriteLine("What would you like to do next? \n(0) Talk to someone \n(1) Go to a secret room \n(2) Order a meal");
            }
            else if(location == decision1[1])
            {
                Console.WriteLine("What would you like to do next? \n(0) Read a book \n(1) Enter an office \n(2) Buy a book");
            }

            string d2 = decision2[Convert.ToInt32(Console.ReadLine())];
            switch (d2)
            {
                case "Go ahead":
                    if (location == decision1[0])
                        Console.WriteLine("You decided to have a chat with someone. It was nice getting to talk to people.");
                    else if (location == decision1[1])
                        Console.WriteLine("You decided to read a book. It was nice getting to learn something good.");
                        break;
                case "Use key":
                    if (location == decision1[0])
                    {
                        if(inventory.Contains(key))
                        {
                            Console.WriteLine("You entered the secret room and found a shiny ring.");
                            inventory.Add(ring);
                        }
                        else
                        {
                            Console.WriteLine("You tried to enter the room, but it was locked. Too bad you don't have a key with you.");
                        }
                    }
                        
                    else if (location == decision1[1])
                    {
                        if (inventory.Contains(key))
                        {
                            Console.WriteLine("You entered the office and found some documents.");
                            inventory.Add(document);
                        }
                        else
                        {
                            Console.WriteLine("You tried to enter the office, but it was locked. Too bad you don't have a key with you.");
                        }
                    }
                    break;
                case "Use coin":
                    if (location == decision1[0])
                    {
                        if (inventory.Contains(key))
                        {
                            Console.WriteLine("You ordered a sandwich and a cup of coffee for breakfast.");
                            inventory.Add(sandwich);
                            inventory.Add(coffee);
                            inventory.Remove(coin);
                        }
                        else
                        {
                            Console.WriteLine("Too bad you don't have a coin to spend for breakfast.");
                        }
                    }

                    else if (location == decision1[1])
                    {
                        if (inventory.Contains(coin))
                        {
                            Console.WriteLine("You bought a book to read from the school library.");
                            inventory.Add(book);
                            if(Game.Lucky())
                            {
                                Console.WriteLine("It's your lucky day! The librarian decided to also give you a sheet of stickers and a pencil as well.");
                                inventory.Add(stickers);
                                inventory.Add(pencil);
                            }
                            inventory.Remove(coin);
                        }
                        else
                        {
                            Console.WriteLine("Too bad you don't have a coin to spend for a book.");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

            Console.WriteLine("Would you like to describe what you currently have? \n(0) Yes \n(1) No");
            bool d3 = decision3[Convert.ToInt32(Console.ReadLine())];
            if (d3)
            {
                Console.WriteLine("You currently have:");
                foreach (Item i in inventory)
                {
                    Console.WriteLine(i.name);
                    i.Describe();
                }
            }
            else
            {
                Console.WriteLine("You don't want to describe what you found? Aww.");
            }

            Console.WriteLine("Thanks for playing the adventure game demo!");
        }
    }
}
