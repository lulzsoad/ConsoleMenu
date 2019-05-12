using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu.Programming_Fundamentals_Exercises
{
    static class Template
    {
        static public void Start()
        {
            PrintExercise();
            Code();
        }

        static void PrintExercise()
        {
            Console.Clear();
            Console.WriteLine("Task");
            Console.WriteLine("Code:\n");
            Console.WriteLine();
        }

        static void Code()
        {
            while (true)
            {
                KeyFunctions();

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
