using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt user to input a number 
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            //print out odd number 
            //use for loop to run through 
            for (int i = 0; i < number; i+=2) {
                sum = sum + i;
            }
            //print out sum
            Console.WriteLine(sum);
        }
    }
}
