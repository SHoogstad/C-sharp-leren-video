using System;

namespace Calculator
{
    internal static class Program
    {
        public static void Main()
        {
            double num1 = 0;
            try
            {
                Console.Write("enter your first Number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("invalid number try again");
                Main();
            }
            
            Console.Write("Enter Operator: ");
            var op = Console.ReadLine();


            double num2 = 0;
            try
            {
                Console.Write("enter your second Number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("invalid number try again");
                Main();
            }
            
            switch (op)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("Invalid operator try again");
                    Main();
                    break;
            }


            Console.ReadLine();
        }
    }
}