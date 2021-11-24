using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Item
    {
        public string name;
        private string description;

        private static string[] items = {"key", "coin", "ring", "sandwich", "coffee", "document", "book", "stickers", "pencil" };
        private static string[] descriptions = { 
        "A key useful for unlocking doors.",
        "A coin useful for buying things.",
        "A shiny ring. It looks pretty, doesn't it?",
        "A delicious sandwich. Good for breakfast.",
        "A cup of coffee, for getting yourself some energy.",
        "A document containing important and interesting information.",
        "A book with something interesting to read and learn.",
        "A sheet of colorful stickers that can decorating anything you like.",
        "A pencil useful for writing. Good for taking notes or drawing pictures."
        };

        public Item(int i)
        {
            name = items[i];
            description = descriptions[i];
        }
        public void Describe()
        {
            Console.WriteLine(description);
        }
    }
}
