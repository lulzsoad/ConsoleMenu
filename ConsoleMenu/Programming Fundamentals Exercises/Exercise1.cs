using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu.Programming_Fundamentals_Exercises
{
    static class Exercise1
    {
        static public void Start()
        {
            PrintExercise();
            Code();
        }

        static void PrintExercise()
        {
            Console.Clear();
            Console.WriteLine("Declare two integer variables and assign arbitrary values to them. Print to the console the result of adding these two numbers up.\n");
            Console.WriteLine("Code:\n");
            Console.WriteLine("\tint a, b, result;\n\tstring aText, bText;\n\n\tConsole.WriteLine(\"Enter first number:\");\n\taText = Console.ReadLine();\n\tConsole.WriteLine(\"Enter second number: \");\n\tbText = Console.ReadLine();\n\n\tint.TryParse(aText, out a);\n\tint.TryParse(bText, out b);\n\n\tresult = a + b;\n\n\tConsole.WriteLine(\"{0} + {1} = {2}\", a, b, result); ");
        }

        static void Code()
        {
            while (true)
            {
                KeyFunctions();

                int a, b, result;
                string aText, bText;

                Console.WriteLine("Enter first number:");
                aText = Console.ReadLine();
                Console.WriteLine("Enter second number: ");
                bText = Console.ReadLine();

                int.TryParse(aText, out a);
                int.TryParse(bText, out b);

                result = a + b;

                Console.WriteLine("{0} + {1} = {2}", a, b, result);
            }
        }

        static void KeyFunctions()
        {
            Console.WriteLine("\n\nPress any key to start\n");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
                ProgrammingFundamentalsCSharp.StartMenu();
        }
    }
}
