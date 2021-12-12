using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySim
{
    class Program
    {
        /* Library Simulator
         * 
         * The library simulator will read form an inventory text file in this format:
         * | Title | Author | Genre | ID Number | Page Count | Amount in stock |
         * The file will be read line by line, with each line being parsed into an array containing information about the book.
         * This information will then be sent to a constuctor for the "Book" class.
         * 
         * The user can then register customers into a queue by typing in the appropriate information.
         * Once the user is done registering customers the user can then check out books for these customers one by one.
         * 
         * When all customers are done checking out their books, the library simulator will print out a receipt in the form of a text file.
         * That receipt will
         * 
         */
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Path.GetFullPath("Inventory.txt")))
            {
                string nextLine;
                while ((nextLine = sr.ReadLine()) != null)
                {
                    Library.registerBook(nextLine);
                }
            }

            Console.WriteLine("Welcome to the library!");
            Queue<Customer> customerLine = new Queue<Customer>();
            Stack<Customer> finishedCustomers = new Stack<Customer>();

            Console.WriteLine("First, enter customer information.");
            bool addingCustomers = true;
            // Section for registring customers
            do
            {
                try
                {
                    Console.WriteLine("Enter your full name:");
                    string customerName = Console.ReadLine();
                    Console.WriteLine("Enter your age:");
                    int customerAge = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your ID number:");
                    int customerID = Int32.Parse(Console.ReadLine());
                    customerLine.Enqueue(new Customer(customerName, customerAge, customerID));
                    Console.WriteLine("Do you want to add a new customer? (Type \"Yes\" to do so)");
                    string yesNo = Console.ReadLine();
                    if (yesNo.ToUpper() != "YES")
                        addingCustomers = false;
                }
                catch(FormatException fe)
                {
                    Console.WriteLine($"Invalid input. {fe.Message} Please try again.");
                    continue;
                }
            }
            while (addingCustomers);

            // Section for customer activity
            while (customerLine.Count() > 0)
            {
                Customer nextCustomer = customerLine.Dequeue();
                bool customerOnline = true;
                do
                {
                    try
                    {
                        Console.WriteLine($"Current customer: {nextCustomer.Name} | Age: {nextCustomer.Age} | ID: {nextCustomer.ID}");
                        Console.WriteLine("Pick a service by typing in the appropriate number:\n" +
                            "(1) Search books by title\n" +
                            "(2) Search books by author name\n" +
                            "(3) Search books by genre\n" +
                            "(4) Check out a book\n" +
                            "(5) Return a book\n" +
                            "(6) Review your list\n" +
                            "(7) Finish");
                        char action = Convert.ToChar(Console.ReadLine());
                        switch (action)
                        {
                            case '1':
                                Library.searchByTitle();
                                break;
                            case '2':
                                Library.searchByAuthor();
                                break;
                            case '3':
                                Library.searchByGenre();
                                break;
                            case '4':
                                Library.checkOutBook(nextCustomer);
                                break;
                            case '5':
                                Library.returnBook(nextCustomer);
                                break;
                            case '6':
                                nextCustomer.reviewList();
                                break;
                            case '7':
                                Console.WriteLine($"Thank you for using the library, {nextCustomer.Name}.");
                                nextCustomer.reviewList();
                                finishedCustomers.Push(nextCustomer);
                                customerOnline = false;
                                break;
                            default:
                                Console.WriteLine("Invalid input. Please try again.");
                                break;
                        }
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine($"Invalid input. {fe.Message} Please try again.");
                    }
                }
                while (customerOnline);
            }
            Library.printReceipt(finishedCustomers); // Note: The receipt will go to the /bin/Debug/net5.0 directory.
            Console.WriteLine("Thank you for using the library system to check out some cool books! Good luck, and have a nice day!");
        }
    }
}
