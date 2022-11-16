
using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Hello();
            Console.ReadLine();
        }

        private static void Hello()
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            string message = $"hello {name}!"; 
            Console.WriteLine(message);
        }
    }
}