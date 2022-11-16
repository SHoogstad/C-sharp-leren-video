
using System;
using System.CodeDom;

namespace ConsoleApplication1
{
    internal static class Program
    {
        public static void Main()
        {
            HeroVsMonster();
            Console.ReadLine();
            Main();
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
        
        
        // While loop Hero Vs Monster
            private static void HeroVsMonster()
            {
                var attack = new Random() ;
                var HPhero = 100;
                var HPMonster = 100;
                while (HPhero > 0 && HPMonster > 0)
                {
                    var currentAttackHero = attack.Next(5, 25);
                    HPMonster -= currentAttackHero;
                    Console.WriteLine($"Hero attacked the Monster Lost {currentAttackHero} HP, Monster HP now is {HPMonster}");
                    
                    var selfDestruct = new Random().Next(1, 10);
                        if (selfDestruct != 5 )
                        {
                            if (HPMonster <= 0) break;
                        }else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            HPMonster = 1; // to fix that you don't get false win condition
                            Console.WriteLine($"Monster self destructed!. The Hero and the Monster both are dead");
                            Console.ResetColor();
                            break;
                        }
                    
                    
                    var currentAttackMonster = attack.Next(6, 23);
                    HPhero -= currentAttackMonster;
                    Console.WriteLine($"Monster attacked the Hero Lost {currentAttackMonster} HP, Monster HP now is {HPhero}");
                }

                if (HPMonster <= 0)
                {            
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Hero won! with {HPhero}HP left");
                    Console.ResetColor();
                }
                else if (HPhero <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Monster won! with {HPMonster}HP left");
                    Console.ResetColor();
                }
            }
        //
    }
}