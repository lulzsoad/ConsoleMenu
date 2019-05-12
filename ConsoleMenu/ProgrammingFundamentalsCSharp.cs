using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    static class ProgrammingFundamentalsCSharp
    {
        static string[] menuOptions = {"Exercise 1", "Exercise 2"};
        static int activeMenuOption = 0;

        public static void StartMenu()
        {
            Console.Title = "";
            Console.CursorVisible = false;

            while (true)
            {
                MenuShow();
                ChooseOption();
                RunOption();
            }
        }

        static void MenuShow()
        {
            Console.Clear();
            Console.WriteLine(">>> Programming Fundamentals C# - Exercises <<<");
            Console.WriteLine();

            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == activeMenuOption)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("{0,-35}", menuOptions[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine(menuOptions[i]);
                }
            }
        }

        static void ChooseOption()
        {
            do
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                {
                    activeMenuOption = (activeMenuOption > 0) ? activeMenuOption - 1 : menuOptions.Length - 1;
                    MenuShow();
                }
                else if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                {
                    activeMenuOption = (activeMenuOption == menuOptions.Length - 1) ? 0 : activeMenuOption + 1;
                    MenuShow();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Menu.StartMenu();
                    break;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    //RunOption();
                    break;
                }
            }
            while (true);
        }

        public static void RunOption()
        {
            switch (activeMenuOption)
            {
                case 0:
                    Programming_Fundamentals_Exercises.Exercise1.Start();
                    break;
                case 1:
                    Programming_Fundamentals_Exercises.Exercise2.Start();
                    break;
            }
        }
    }
}
