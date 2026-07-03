using System;

namespace Calculator
{
    class Calcus

    {
        static async Task Main()
        {


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Loading: 0%");

            for (int i = 1; i <= 100; i += 1)
            {
                Random random = new Random();
                int number = random.Next(1,2);

                await Task.Delay(number + number + number);

                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"Loading... {i}%   ");
            }
            
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("=== Calculator ===");

            // Calculate functions together = Result
            Console.Write("Calculate Task: ");
            string? input = Console.ReadLine();

            int Ioo = 100;
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
                Console.WriteLine("Invalid Calculation Character...");
                return;
            }

            string[] Numb = input.Split(selector);

            double num1 = Convert.ToDouble(Numb[0]);
            double num2 = Convert.ToDouble(Numb[1]);
            


            // Tells the number to begin at = Zero
            double result =0;

            // Diffrent Fucntions
            switch (selector)
            {
            // Adds plus function
            case '+':
                result = num1 + num2;
                break;
            
            // Adds minus function
            case '-':
                result = num1 - num2;
                break;

            // Adds multiplication function
            case '*':
                result = num1 * num2;
                break;

            // Adds divide function
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Invalid Function");
                    return;
                }
                result = num1 / num2;
                break;
            

            // Adds percentage function
            case '%':
                    result = num1 + num2 * 100;
                    break; 
            
            case '=':
                    result = num1 / Ioo / num2;
                    break;

                default:
            Console.WriteLine("Invalid Input");

            return;  
            }
                Console.ForegroundColor=ConsoleColor.Yellow;
                Console.WriteLine(" ");
                foreach (char Number in result.ToString())
                Console.WriteLine("Converting: "+ Number);
                Console.ResetColor();
            
                // Converting Numbers to Letters.

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
                    }
                }

                // Adds all into a result
                Console.WriteLine($"Result:       {letterResult}");

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            
        }    
    }
}    