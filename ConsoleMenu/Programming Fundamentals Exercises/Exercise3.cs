using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu.Programming_Fundamentals_Exercises
{
    class Exercise3
    {
        static public void Start()
        {
            PrintExercise();
            Code();
        }

        static void PrintExercise()
        {
            Console.Clear();
            Console.WriteLine("Declare an array of integers containing 30 elements. With the help of a loop, assign random values to the array elements. Then print to the console all the contents of the array.");
            Console.WriteLine("\nCode:\n");
            Console.WriteLine("int[] tab = new int[30];\nRandom rand = new Random();\n\nfor (int i = 0; i < tab.Length; i++)\n\ttab[i] = rand.Next(0, 100); // returns random number between 0 and 100\n\nfor (int i = 0; i < tab.Length; i++)\n\tConsole.Write(\"{ 0} \", tab[i]);");
        }

        static void Code()
        {
            while (true)
            {
                KeyFunctions();

                int[] tab = new int[30];
                Random rand = new Random();

                for (int i = 0; i < tab.Length; i++)
                    tab[i] = rand.Next(0, 100); // returns random number between 0 and 100

                for (int i = 0; i < tab.Length; i++)
                    Console.Write("{0} ", tab[i]);
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
