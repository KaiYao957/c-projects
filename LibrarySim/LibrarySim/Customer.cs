using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySim
{
    class Customer: CustomerInterface
    {
        public Customer()
        {
            this.Name = "Unnamed";
            this.Age = 10;
            this.ID = 1;
            this.Books = new List<Book>();
        }
        public Customer(string n, int a, int id)
        {
            this.Name = n;
            this.Age = a;
            this.ID = id;
            this.Books = new List<Book>();
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int ID { get; private set; }
        public List<Book> Books { get; set; }
        public bool Contains(int id)
        {
            foreach(Book b in this.Books)
            {
                if(b.ID == id)
                {
                    return true;
                }
            }
            return false;
        }
        public void reviewList()
        {
            Console.WriteLine($"Full list of books checked out by {this.Name}:");
            foreach (Book b in this.Books)
            {
                Console.WriteLine($"{b.Title} by {b.Author} \t Genre: {b.Genre} | {b.PageCount} pages | ID#: {b.ID} | {b.Amount} owned");
                Console.WriteLine("|----------------------------------------------------------------------------------------------------------------------------------------------------|");
            }
            Console.WriteLine();
        }
    }
}
