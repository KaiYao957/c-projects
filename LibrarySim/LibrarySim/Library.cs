using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibrarySim
{
    static class Library
    {
        public static List<Book> BookInventory = new List<Book>(); // The database of all books available in the library.
        public static void registerBook(string bookData_s)
        {
            // bookData_s refers to the book information in its original string form,
            // while bookData_a refers to the book information after it is parsed into an array.
            string[] bookData_a = bookData_s.Split('_');
            BookInventory.Add(new Book(bookData_a[0], bookData_a[1], bookData_a[2],
                Int32.Parse(bookData_a[3]), Int32.Parse(bookData_a[4]), UInt32.Parse(bookData_a[5])));
        }

        public static void searchByTitle()
        {
            Console.WriteLine("Type in the title of the book(s) you want to find:");
            string t = Console.ReadLine();
            var searchResults = BookInventory.Where(b => b.Title.ToUpper().Contains(t.ToUpper()));
            if (searchResults.Count() == 0)
            {
                Console.WriteLine($"Sorry, no books named {t} could be found.");
                return;
            }
            Console.WriteLine($"{searchResults.Count()} results found for books titled \"{t}\".");
            foreach (Book b in searchResults)
            {
                Console.WriteLine($"{b.Title} by {b.Author} \t Genre: {b.Genre} | {b.PageCount} pages | ID#: {b.ID} | {b.Amount} copies left in stock");
                Console.WriteLine("|----------------------------------------------------------------------------------------------------------------------------------------------------|");
            }
        }
        public static void searchByAuthor()
        {
            Console.WriteLine("Type in the name of the author of the book(s) you want to find:");
            string a = Console.ReadLine();
            var searchResults = BookInventory.Where(b => b.Author.ToUpper().Contains(a.ToUpper()));
            if (searchResults.Count() == 0)
            {
                Console.WriteLine($"Sorry, no books by {a} could be found.");
                return;
            }
            Console.WriteLine($"{searchResults.Count()} results found for books by {a}.");
            foreach (Book b in searchResults)
            {
                Console.WriteLine($"{b.Title} by {b.Author} \t Genre: {b.Genre} | {b.PageCount} pages | ID#: {b.ID} | {b.Amount} copies left in stock");
                Console.WriteLine("|----------------------------------------------------------------------------------------------------------------------------------------------------|");
            }
        }
        public static void searchByGenre()
        {
            Console.WriteLine("Type in a genre for the book(s) you want to find:");
            string g = Console.ReadLine();
            if (g.ToUpper() == "SCI FI" || g.ToUpper() == "SCI-FI")
                g = "Science Fiction";
            var searchResults = BookInventory.Where(b => b.Genre.ToUpper() == g.ToUpper());
            if (searchResults.Count() == 0)
            {
                Console.WriteLine($"Sorry, no book of genre \"{g}\" could be found.");
                return;
            }
            Console.WriteLine($"{searchResults.Count()} results found for genre \"{g}\".");
            foreach (Book b in searchResults)
            {
                Console.WriteLine($"{b.Title} by {b.Author} \t Genre: {b.Genre} | {b.PageCount} pages | ID#: {b.ID} | {b.Amount} copies left in stock");
                Console.WriteLine("|----------------------------------------------------------------------------------------------------------------------------------------------------|");
            }
        }

        public static void checkOutBook(Customer c)
        {
            Console.WriteLine("Type the ID number of the book that you want to check out:");
            try
            {
                int idNumber = Int32.Parse(Console.ReadLine());
                Book selected = null;
                foreach (Book b in BookInventory)
                {
                    if (b.ID == idNumber)
                    {
                        selected = b;
                    }
                }
                if (selected == null)
                {
                    Console.WriteLine($"Sorry, no book of ID number \"{idNumber}\" could be found.");
                    return;
                }
                Console.WriteLine($"You have selected: {selected.Title} by {selected.Author} \t Genre: {selected.Genre} | {selected.PageCount} pages | ID#: {selected.ID} | {selected.Amount} copies left in stock");
                Console.WriteLine("How many copies of this book do you want to check out?");
                uint atc = UInt32.Parse(Console.ReadLine()); // ATC means "amount to checkout"
                if(atc > selected.Amount)
                {
                    Console.WriteLine("Too many copies requested for selected book.");
                    return;
                }
                selected -= atc;
                Book currentBook = c.Books.Find(b => b.ID == selected.ID);
                if(currentBook == null)
                {
                    if(atc > 0)
                    c.Books.Add(new Book(selected.Title, selected.Author, selected.Genre, selected.ID, selected.PageCount, atc));
                }
                else
                {
                    currentBook += atc;
                }
                // Removes book from inventory is the library runs out of copies of that book
                if(selected.Amount <= 0)
                {
                    BookInventory.Remove(selected);
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Error: " + fe.Message);
            }
        }

        public static void returnBook(Customer c)
        {
            Console.WriteLine("Type the ID number of the book that you want to return:");
            try
            {
                int idNumber = Int32.Parse(Console.ReadLine());
                Book selected = null;
                foreach (Book b in c.Books)
                {
                    if (b.ID == idNumber)
                    {
                        selected = c.Books.Find(b => b.ID == idNumber);
                    }
                }
                if (selected == null)
                {
                    Console.WriteLine($"Sorry, you currently do not possess any book of ID number \"{idNumber}\".");
                    return;
                }
                Console.WriteLine($"You have selected: {selected.Title} by {selected.Author} \t Genre: {selected.Genre} | {selected.PageCount} pages | ID#: {selected.ID} | {selected.Amount} copies owned");
                Console.WriteLine("How many copies of this book do you want to return?");
                uint atr = UInt32.Parse(Console.ReadLine()); // ATR means "amount to return"
                if (atr > selected.Amount)
                {
                    Console.WriteLine("Insufficient copies owned to return.");
                    return;
                }
                selected -= atr;
                Book currentBook = BookInventory.Find(b => b.ID == selected.ID);
                if(currentBook == null)
                {
                    if(atr > 0)
                    BookInventory.Add(new Book(selected.Title, selected.Author, selected.Genre, selected.ID, selected.PageCount, atr));
                }
                else
                {
                    currentBook += atr;
                }
                // Removes book from customer's book list if the customer returns all copies of the book
                if (selected.Amount <= 0)
                {
                    c.Books.Remove(selected);
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Error: " + fe.Message);
            }
        }

        public static void printReceipt(Stack<Customer> finishedCustomers)
        {
            Console.WriteLine("Type in the name for your library checkout receipt:");
            string receiptName = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(Path.GetFullPath($"{receiptName}.txt")))
            {
                while (finishedCustomers.Count() > 0)
                {
                    Customer nextCustomer = finishedCustomers.Pop();
                    nextCustomer.reviewList();
                    sw.WriteLine($"{nextCustomer.Name} | Age: {nextCustomer.Age} | ID: {nextCustomer.ID}");
                    sw.WriteLine($"Full list of books checked out by this customer:");
                    foreach (Book b in nextCustomer.Books)
                    {
                        sw.WriteLine($"{b.Title} by {b.Author} \t Genre: {b.Genre} | {b.PageCount} pages | ID#: {b.ID} | {b.Amount} owned");
                        sw.WriteLine("|----------------------------------------------------------------------------------------------------------------------------------------------------|");
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}
