using System;
using ClockHandAngleCalculator.Validations;

namespace ClockHandAngleCalculator
{
    internal class Program
    {
        static void Main()
        {
            var calculator = new Calculator();
            var hourValidator = new HourValidator();
            var minuteValidator = new MinuteValidator();
            var isContinuing = true;

            while (isContinuing)
            {
                var hourString = "";
                var minuteString = "";
                var inputsValid = false;

                while (!inputsValid)
                {
                    Console.WriteLine("Enter hours (1 - 12)");
                    hourString = Console.ReadLine();
                    Console.WriteLine("Enter minutes (0 - 59)");
                    minuteString = Console.ReadLine();

                    if (hourValidator.IsValid(hourString) && minuteValidator.IsValid(minuteString))
                    {
                        inputsValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }

                var angleBetweenHands = calculator.Calculation(hourString, minuteString);

                Console.WriteLine($"Angle between hands is {angleBetweenHands} degrees");
                Console.WriteLine("Continue? Y/N");

                var continueCalculations = Console.ReadKey();

                if (continueCalculations.KeyChar.ToString().ToLower() != "y")
                {
                    isContinuing = false;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
