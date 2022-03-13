using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    internal class Program
    {
        /* 
         * IsPrime(int n):
         * Method which checks each number as a factor of "n", from 2 to "n-1"
         * If ith number divides n evenly,
         * Then n is not a prime number; returns false
         * If numbers from 2 to "n-1" are not factors of n,
         * Then n is a prime number; returns true
         */
        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        /* 
         * FirstNPrime(int[] a, int n):
         * Method which fills an array "a" of length "n", with the first "n" prime number by order
         * Then returns the array
         */
        public static int[] FirstNPrime(int[] a, int n)
        {
            // variable initializations:
            int i = 0, counter = 2; // i for index `a[i]`, counter for counting till the ith prime number

            while (i < n)
            {
                if (IsPrime(counter))
                {
                    a[i] = counter;
                    i++;
                }
                counter++; // we assigned the count value to 2 because 2 is the first prime number
            }

            return a;
        }

        /* 
         * DisplayArray(int[] a, int length):
         * Method which iterates over an array "a" of length "length",
         * Then prints each cell of the array.
         */
        public static void DisplayArray(int[] a, int length)
        {
            for (int i = 0; i < length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine("\n");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose N to display the first N prime number:");
            int length = int.Parse(Console.ReadLine());
            int[] myArray = new int[length];
            FirstNPrime(myArray, length);
            Console.WriteLine("\nHere are your first " + length + " prime number:");
            DisplayArray(myArray, length);
        }
    }
}
