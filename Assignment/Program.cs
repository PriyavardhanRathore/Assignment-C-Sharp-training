using System;

namespace Assignment
{
    class Program
    {

        enum Color { Red = 1, Blue = 2, Green = 3, Orange = 4, Purple = 5, Black = 6, White = 7 };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Color:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string col = Console.ReadLine();

           Color colorValue = (Color)Enum.Parse(typeof(Color), col, true);
            switch (colorValue)
            {
                case Color.Red:
                    Console.WriteLine("Red Color");
                    break;
                case Color.Blue:
                    Console.WriteLine("Blue Color");
                    break;
                case Color.Green:
                    Console.WriteLine("Green Color");
                    break;
                case Color.Orange:
                    Console.WriteLine("Orange color");
                    break;
                case Color.Purple:
                    Console.WriteLine("Purple color");
                    break;
                case Color.Black:
                    Console.WriteLine("Black color");
                    break;
                case Color.White:
                    Console.WriteLine("White color");
                    break;
                default:
                    Console.WriteLine("Invalid Color");
                    break;

            }
            Console.ReadLine();

        }
    }
}
