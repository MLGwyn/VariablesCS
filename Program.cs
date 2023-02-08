using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 2;
            var fullName = "Melissa Gwyn";
            var rightNow = DateTime.Now;
            var currentDate = rightNow.ToShortDateString();

            Console.WriteLine($"{numberOfCupsOfCoffee} {fullName} {currentDate} ");

            Console.WriteLine("What is your name? ");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}, it's nice to meet you!");

            Console.WriteLine("Please give me a number...");
            var firstNumberAsString = Console.ReadLine();

            Console.WriteLine("Please give me another number...");
            var secondNumberAsString = Console.ReadLine();

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            Console.WriteLine($"{firstNumberAsString}+{secondNumberAsString}={sum}");

            Console.WriteLine($"{firstNumberAsString}-{secondNumberAsString}={difference}");

            Console.WriteLine($"{firstNumberAsString}x{secondNumberAsString}={product}");

            Console.WriteLine($"{firstNumberAsString}÷{secondNumberAsString}={quotient.ToString("N3")}");

            Console.WriteLine($"The remainder of {quotient.ToString("N3")} is {remainder}");




        }

    }
}
