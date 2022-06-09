using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvelonInternshipTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //passing by value
            int number = 56;
            Console.WriteLine($"Number before: {number}");
            ValueType(number);
            Console.WriteLine($"Number after: {number}");


            //passing by reference
            int[] numbers = new int[1];
            
            numbers[0] = 100;

            Console.WriteLine(numbers[0]);

            ReferenceType(numbers);
            Console.WriteLine(numbers[0]);

            Console.ReadKey();
        }

        public static void ValueType(int number)
        {
            number += 1;
            Console.WriteLine($"Inside function: {number}");

        }

        public static void ReferenceType(int[] numbers)
        {
            numbers[0] += 1;
        }
    }
}
