
using System;
using System.CodeDom;

namespace ConsoleApplication1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            FizzBuzz_2();
            Console.ReadLine();
        }

        // methods 
            private static void Hello()
            {
                Console.Write("Enter your name:");
                var name = Console.ReadLine(); // wanneer je een variable gelijk initialised gebruik var anders type
                var message = $"hello {name}!"; 
                Console.WriteLine(message);
            }
        //
        
        // return types
            private static string HelloReturn()
            {
                Console.Write("Enter your name:");
                var name = Console.ReadLine();
                var message = $"hello {name}!";
                return message;
            }

            private static int Cube(int number)
            {
                number = number * number * number;
                return number;
            }
        //
        
        // fizz buzz (if statements and loops)
            private static void FizzBuzz()
            {
                for (var i = 1; i < 101; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine($"{i} - fizz");
                    }else if (i % 5 == 0)
                    {
                        Console.WriteLine($"{i} - buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            
            private static void FizzBuzz_2()
            {
                for (var i = 1; i < 101; i++)
                {
                    if (i % 3 == 0)
                        Console.WriteLine($"{i} - fizz");
                    else if (i % 5 == 0)
                        Console.WriteLine($"{i} - buzz");
                    else
                        Console.WriteLine(i);
                }
            }
        //
    }
}