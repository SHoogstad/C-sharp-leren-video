
using System;

namespace ConsoleApplication1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Hello();
            Console.ReadLine();
        }

        private static void Hello()
        {
            Console.Write("Enter your name:");
            var name = Console.ReadLine(); // wanneer je een variable gelijk initialised gebruik var anders type
            var message = $"hello {name}!"; 
            Console.WriteLine(message);
        }
    }
}