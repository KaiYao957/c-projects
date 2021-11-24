using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //FileStream fs = new FileStream("readFile.txt", FileMode.Open, FileAccess.Read);
                //string[] linesToRead = File.ReadAllLines(fs.Name);
                string[] linesToRead = File.ReadAllLines("readFile.txt");
                for (int i = 0; i<linesToRead.Length; i++)
                {
                    Console.WriteLine($"|+| {linesToRead[i]} |+|");
                }
            }
            catch(IOException ioe)
            {
                Console.WriteLine("\a" + ioe.Message);
            }

            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                
                StreamWriter sw1 = new StreamWriter("sampleFile.txt");
                sw1.WriteLine("ABCDEFGHIJKLOMNOP");
                sw1.WriteLine("QRSTUVWXYZ");
                for(int i = 1; i<=25; i+=2)
                {
                    sw1.Write(i + " ");
                }
                sw1.Flush();
                sw1.Close();
                StreamReader sr = new StreamReader("sampleFile.txt");
                Console.WriteLine(readFromFile(sr));
                sr.Close();
            }
            catch (IOException ioe)
            {
                Console.WriteLine("\a" + ioe.Message);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Type in whatever you like to write:");
            string input = Console.ReadLine();
            writeToFile("writeFile.txt", input);

        }

        static string readFromFile(StreamReader sr)
        {
            return sr.ReadToEnd();
        }
        
        static void writeToFile(string fileName, string input)
        {
            File.WriteAllText(fileName, input);
        }
    }
}
