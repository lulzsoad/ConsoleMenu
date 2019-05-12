using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu.Programming_Fundamentals_Exercises
{
    static class Exercise2
    {
        static public void Start()
        {
            PrintExercise();
            Code();
        }

        static void PrintExercise()
        {
            Console.Clear();
            Console.WriteLine("Declare a couple of floating point variables in one line. Initialise some of them witharbitrary values.\n\n float - +/- 1.5 * 10^-45 to +/- 3.4 * 10^38\n double - +/- 5.0 * 10^-324 to 1.7 * 10^308\n decimal - +/- 1.0 * 10^-28 to 7.9 * 10^28\n");
            Console.WriteLine("Code:\n");
            Console.WriteLine("float fa, fb, fc;\ndouble da, db, dc;\ndecimal dea, deb, dec;\n\nConsole.WriteLine(\"Enter float type number\");\nfloat.TryParse(Console.ReadLine(), out fa);\nConsole.WriteLine(\"Enter double type number\");\ndouble.TryParse(Console.ReadLine(), out da);\nConsole.WriteLine(\"Enter decimal type number\");\ndecimal.TryParse(Console.ReadLine(), out dea);\n\nConsole.WriteLine(\"\\nfloat: {0}\\ndouble: {1}\\ndecimal: {2}\", fa, da, dea)");
        }

        static void Code()
        {
            while (true)
            {
                KeyFunctions();

                float fa, fb, fc;
                double da, db, dc;
                decimal dea, deb, dec;

                Console.WriteLine("Enter float type number");
                float.TryParse(Console.ReadLine(), out fa);
                Console.WriteLine("Enter double type number");
                double.TryParse(Console.ReadLine(), out da);
                Console.WriteLine("Enter decimal type number");
                decimal.TryParse(Console.ReadLine(), out dea);

                Console.WriteLine("\nfloat: {0}\ndouble: {1}\ndecimal: {2}", fa, da, dea);

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
