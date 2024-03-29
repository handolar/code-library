// See https://aka.ms/new-console-template for more information
using System;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            int playerChoice = GetPlayerInput();
            
            while (playerChoice != 4)
            {
                switch (playerChoice)
                {
                    case 1:
                        Console.WriteLine("Creating new world...");
                        break;
                    case 2:
                        Console.WriteLine("Loading game...");
                        break;
                    case 3:
                        Console.WriteLine("This is the option menu");
                        break;
                    default:
                        Console.WriteLine("Por favor no sea retrasado :)");
                        break;
                } 
                playerChoice = GetPlayerInput();
            }

            Console.WriteLine("Goodbye!");
        }

        private static int GetPlayerInput()
        {
            Console.Write("Digite el numero de la opcion deseada: ");
            return int.Parse(Console.ReadLine());
        }

        private static void PrintMenu()
        {
            Console.WriteLine(@"
                **************

                Menu:

                1 - New Game

                2 - Load Game

                3 - Options

                4 - Quit

                **************
            ");
        }
    }
}