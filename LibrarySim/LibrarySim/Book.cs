using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySim
{
    class Book:BookInterface
    {
        public Book()
        {
            this.Title = "Untitled";
            this.Author = "Unknown";
            this.Genre = "Undefined";
            this.ID = 1;
            this.PageCount = 100;
            this.Amount = 1;
        }
        public Book(string t, string a, string g, int id, int pc, uint amt)
        {
            this.Title = t;
            this.Author = a;
            this.Genre = g;
            this.ID = id;
            this.PageCount = pc;
            this.Amount = amt;
        }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Genre { get; private set; }
        public int ID { get; private set; }
        public int PageCount { get; private set; }
        public uint Amount { get; set; }
        public static Book operator+ (Book b, uint n)
        {
            b.Amount += n;
            return b;
        }
        public static Book operator- (Book b, uint n)
        {
            b.Amount -= n;
            return b;
        }
    }
}
