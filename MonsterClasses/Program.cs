using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomeScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        static SeaMonster InitializeSeaMonster()
        {
            return new SeaMonster()
            {
                Id = 24,
                Name = "Suzy",
                Age = 473,
                HasGills = true,
                HomeSea = "Baltic"
            };
        }
        static SpaceMonster InitializeSpaceMonster()
        {
            return new SpaceMonster()
            {
                Id = 56,
                Name = "Sid",
                Age = 18,
                Galaxy = "Andromeda"

            };
        }

        private static void DisplayMenu()
        {
            bool exitMenu = false;
            int menuSelection;
            SeaMonster mySeaMonster;
            SpaceMonster mySpaceMonster;

            mySeaMonster = InitializeSeaMonster();
            mySpaceMonster = InitializeSpaceMonster();

            do
            {
                Console.Clear();
                DisplayHeader("Menu");
                Console.WriteLine("1) Display Monsters");
                Console.WriteLine("2) Exit");
                Console.WriteLine();
                Console.Write("Enter Selection:");
                menuSelection = int.Parse(Console.ReadLine());


                switch (menuSelection)
                {
                    case 1:
                       break;
                    case 2:
                        exitMenu = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a proper selection.");
                        DisplayContinuePrompt();
                        break;

                }

            } while (exitMenu);
        }
        static void DisplayMonsterInfoScreen(SeaMonster seaMonster, SpaceMonster spaceMonster)
        {
            DisplayHeader("Monster Info");
            Console.WriteLine("Sea Monster");
            DisplaySeamMonsterInfo(seaMonster);

            Console.WriteLine();
            Console.WriteLine("Space Monster");
            DisplaySpaceMonsterInfo(spaceMonster);

            DisplayContinuePrompt();
        }

        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tWelcome to My App");
            DisplayContinuePrompt();
        }

        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tThank You For using My App");
            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void DisplayHeader(string headText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(headText);
            Console.WriteLine();
        }

    }
}
