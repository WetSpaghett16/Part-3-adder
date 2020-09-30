using System;

namespace Part_3_adder
{
    class Program
    {

        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;

            Console.WriteLine("Enter your first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your total is " + (number1 + number2 + number3));


        }
    }
}
