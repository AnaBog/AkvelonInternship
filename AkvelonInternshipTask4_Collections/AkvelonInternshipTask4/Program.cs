using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvelonInternshipTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list
            List<string> thisIsAList = new List<string>();
            thisIsAList.Add("Jupiter");
            thisIsAList.Add("Neptune");
            thisIsAList.Add("Mercury");

            thisIsAList.ForEach(Console.WriteLine);
            thisIsAList.RemoveAt(1);
            thisIsAList.ForEach(Console.WriteLine);

            //queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            queue.ToList().ForEach(Console.WriteLine);
            queue.Dequeue();
            queue.ToList().ForEach(Console.WriteLine);


            //stack
            Stack<string> numbers = new Stack<string>();
            numbers.Push("1");
            numbers.Push("2");
            numbers.Push("3");

            numbers.ToList().ForEach(Console.WriteLine);
            numbers.Pop();
            numbers.ToList().ForEach(Console.WriteLine);

            //dictionary

            var dictionary = new Dictionary<string, string>();
            dictionary.Add("number", "2");
            dictionary.Add("second number", "3");


            Console.WriteLine(dictionary.Keys);

            foreach (KeyValuePair<string, string> kvp in dictionary)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
            }

            dictionary.Remove("number");

            foreach (KeyValuePair<string, string> kvp in dictionary)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
            }

            Console.ReadKey();
        }
    }
}
