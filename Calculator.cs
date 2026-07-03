using System;
using System.Threading.Tasks;

namespace Calculator
{
    class Calcus
    {
        static async Task Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Loading: 0%");

            for (int i = 1; i <= 100; i++)
            {
                Random random = new Random();
                int number = random.Next(1, 2);

                await Task.Delay(number + number + number);

                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"Loading... {i}%   ");
            }

            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=== Calculator ===");
            Console.ResetColor();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Calculate Task: ");
            string? input = Console.ReadLine();

            char selector = ' ';

            if (input!.Contains('+'))
                selector = '+';
            else if (input.Contains('-'))
                selector = '-';
            else if (input.Contains('*'))
                selector = '*';
            else if (input.Contains('/'))
                selector = '/';
            else if (input.Contains('%'))
                selector = '%';
            else if (input.Contains('='))
                selector = '=';
            else
            {
                Console.WriteLine("Invalid Character...");
                return;
            }

            string[] Numb = input.Split(selector);

            double num1 = Convert.ToDouble(Numb[0]);
            double num2 = Convert.ToDouble(Numb[1]);

            double result = Calculate(num1, num2, selector);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();

            foreach (char Number in result.ToString())
            Console.WriteLine("Converting: " + Number);
            Console.ResetColor();


            string letterResult = " ";

            foreach (char Numbers in result.ToString())
            {
                switch (Numbers)
                {
                    case '1': letterResult += "A "; break;
                    case '2': letterResult += "B "; break;
                    case '3': letterResult += "C "; break;
                    case '4': letterResult += "D "; break;
                    case '5': letterResult += "E "; break;
                    case '6': letterResult += "F "; break;
                    case '7': letterResult += "G "; break;
                    case '8': letterResult += "H "; break;
                    case '9': letterResult += "I "; break;
                    case '0': letterResult += "J "; break;
                    case '.': letterResult += ". "; break;
                }
            }

            Console.WriteLine($"Result:       {letterResult}");


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static double Calculate(double num1, double num2, char selector)
        {
            switch (selector)
            {
                case '+':
                    return num1 + num2;

                case '-':
                    return num1 - num2;

                case '*':
                    return num1 * num2;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Invalid Function");
                        return 0;
                    }
                    return num1 / num2;

                case '%':
                    return num1 + num2 * 100;

                case '=':
                    return num1 - 100 / num2;

                default:
                    Console.WriteLine("Invalid Input");
                    return 0;
            }
        }
    }
}