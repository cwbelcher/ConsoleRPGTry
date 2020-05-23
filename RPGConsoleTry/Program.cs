using Newtonsoft.Json;
using RPGConsoleTry.Adventures;
using RPGConsoleTry.Game;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace RPGConsoleTry
{
    class Program
    {
        private static GameService gameService = new GameService();
        static void Main(string[] args)
        {
            DisplayTitle();
            MainMenu();
        }

        private static void DisplayTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("***************************************************");
            Console.WriteLine("*                                                 *");
            Console.WriteLine("*      ┌─┐┌─┐┌┐┌┌─┐┌─┐┬  ┌─┐  ┌─┐┬─┐┌─┐┬ ┬┬       *");
            Console.WriteLine("*      │  │ ││││└─┐│ ││  ├┤   │  ├┬┘├─┤││││       *");
            Console.WriteLine("*      └─┘└─┘┘└┘└─┘└─┘┴─┘└─┘  └─┘┴└─┴ ┴└┴┘┴─┘     *");
            Console.WriteLine("*                                                 *");
            Console.WriteLine("***************************************************");
            Console.ResetColor();
            Console.ReadKey();
        }

        private static void MainMenu()
        {
            var inputValid = false;

            while (!inputValid)
            { 
                Console.Clear();
                Console.WriteLine("\n\n\t\t(S)tart a new game");
                Console.WriteLine("\t\t(L)oad a game");
                Console.WriteLine("\t\t(C)reate a new character");
                Console.Write("\t\t");
                
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        gameService.StartGame();
                        inputValid = true;
                        break;

                    case "L":
                        LoadGame();
                        inputValid = true;
                        break;

                    case "C":
                        CreateCharacter();
                        inputValid = true;
                        break;

                    default:
                        Console.WriteLine("I'm sorry...I do not understand your request.....");
                        Console.ReadKey();
                        break;
                }
            }

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }

        

        private static void CreateCharacter()
        {
            Console.WriteLine("You are creating a character, good job!");
        }

        private static void LoadGame()
        {
            Console.WriteLine("Gotta save a game before loading one!");
        }
    }
}
