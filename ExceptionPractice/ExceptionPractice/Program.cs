using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the position for the array:");
            try 
            { 
                int n = getNumber(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Number obtained: "+n);
                Console.WriteLine("100/" + n + " = " + 100 / n);
                // n = recursiveFunction(n); // stack overflowing exception

            }
            catch(Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
                Console.WriteLine("Type in two positive numbers: ");
            }

            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                int j = Convert.ToInt32(Console.ReadLine());
                if (i<0 || j<0)
                {
                    throw new Exception("Error: Negative number detected.");
                }
                Console.WriteLine(i+" + "+j+" = "+getSum(i,j));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static int getNumber(int i)
        {
            try { 
                int[] nums = {16, 34, 5, 12, 41 };
                return nums[i];
            }
            catch(Exception error)
            {
                Console.WriteLine("Invalid position. Defaulting to 0.\n"+ error.Message);
                return 0;
            }
        }

        static int recursiveFunction(int n)
        {
            try
            {
                if (n == 0)
                    return n;
                else
                    return recursiveFunction(n);
            }
            catch(StackOverflowException soe)
            {
                Console.WriteLine("Error: "+soe.Message);
                return -1;
            }
        }

        static int getSum(int x, int y) => x + y;
    }
}
