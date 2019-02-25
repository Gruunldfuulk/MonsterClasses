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
                Language = "Deepspeach",
                Age = 473,
                Weight = "850lbs",
                Color = "Purple",
                HasTail = true,
                CanFly = false,
                HasGills = true,
                LaysEggs = true,
                HomeSea = "Baltic",

            };
        }
        static SpaceMonster InitializeSpaceMonster()
        {
            return new SpaceMonster()
            {
                Id = 56,
                Name = "Sid",
                Language = "Unknown",
                Age = 78,
                Weight = "2,500lbs",
                HasTail = false,
                CanFly = true,
                NumberOfEyes = 5,
                Color = "Red",
                Galaxy = "Andromeda",
                System = "PA-99-N2",
                HomePlanet = "JP-M-63",


            };
        }
        static DragonMonster InitializeDragonMonster()
        {
            return new DragonMonster()
            {
                Id = 101,
                Name = "Marduk",
                Language = "Dragonic",
                Age = 760,
                Weight = "1,100lbs",
                HasTail = true,
                CanFly = true,
                Color = "Black",
                BreathElement = "Acid",
                HasTreasure = true,
                DragonCivilAlignment = "Lawful",
                DragonMoralAlignment = "Evil"
                
            };
        }

        private static void DisplayMenu()
        {
            bool exitMenu = false;
            int menuSelection;
            SeaMonster mySeaMonster;
            SpaceMonster mySpaceMonster;
            DragonMonster myDragonMonster;

            mySeaMonster = InitializeSeaMonster();
            mySpaceMonster = InitializeSpaceMonster();
            myDragonMonster = InitializeDragonMonster();

            do
            {
                Console.Clear();
                DisplayHeader("Menu");
                Console.WriteLine("1) Display Monsters");
                Console.WriteLine("2) Edit Sea Monster");
                Console.WriteLine("3) Edit Space Monster");
                Console.WriteLine("4) Edit Monster");
                Console.WriteLine("5) Exit");
                Console.WriteLine();
                Console.Write("Enter Selection:");
                menuSelection = int.Parse(Console.ReadLine());


                switch (menuSelection)
                {
                    case 1:
                        DisplayMonsterInfoScreen(mySeaMonster, mySpaceMonster,myDragonMonster);
                       break;
                    case 2:
                        DisplayEditSeaMonster(mySeaMonster);
                        break;
                    case 5:
                        exitMenu = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a proper selection.");
                        DisplayContinuePrompt();
                        break;

                }

            } while (!exitMenu);
        }

        private static void DisplayEditSeaMonster(SeaMonster mySeaMonster)
        {
            
        }

        static void DisplayMonsterInfoScreen(SeaMonster seaMonster, SpaceMonster spaceMonster, DragonMonster dragonMonster)
        {
            DisplayHeader("Monster Info");
            Console.WriteLine("Sea Monster");
            DisplaySeamMonsterInfo(seaMonster);

            Console.WriteLine();
            Console.WriteLine("Space Monster");
            DisplaySpaceMonsterInfo(spaceMonster);

            Console.WriteLine();
            Console.WriteLine("Dragon Monster");
            DisplayDragonMonsterInfo(dragonMonster);

            DisplayContinuePrompt();
        }

        private static void DisplaySpaceMonsterInfo(SpaceMonster spaceMonster)
        {
            Console.WriteLine($"Id: {spaceMonster.Id}");
            Console.WriteLine($"Name: {spaceMonster.Name}");
            Console.WriteLine($"Age: {spaceMonster.Age}");
            Console.WriteLine($"Language: {spaceMonster.Language}");
            Console.WriteLine($"Color: {spaceMonster.Color}");
            Console.WriteLine($"Weight: {spaceMonster.Weight}");
            Console.WriteLine($"Has a Tail: {spaceMonster.HasTail}");
            Console.WriteLine($"Can Fly: {spaceMonster.CanFly}");
            Console.WriteLine($"Galaxy: {spaceMonster.Galaxy}");
            Console.WriteLine($"Star System: {spaceMonster.System}");
            Console.WriteLine($"Home Planet: {spaceMonster.HomePlanet}");
            Console.WriteLine($"Number of Eyes: {spaceMonster.NumberOfEyes}");
            Console.WriteLine($"Is Happy: {(spaceMonster.IsHappy() ? "yes" : "no") }");
            Console.WriteLine($"Is Hostile: {(spaceMonster.IsHostile() ? "yes" : "no")}");

            Console.WriteLine($"You attacked {spaceMonster.Name} and they {spaceMonster.MonsterBattleResponse()}");
        }

        private static void DisplaySeamMonsterInfo(SeaMonster seaMonster)
        {
            Console.WriteLine($"Id: {seaMonster.Id}");
            Console.WriteLine($"Name: {seaMonster.Name}");
            Console.WriteLine($"Age: {seaMonster.Age}");
            Console.WriteLine($"Language: {seaMonster.Language}");
            Console.WriteLine($"Color: {seaMonster.Color}");
            Console.WriteLine($"Weight: {seaMonster.Weight}");
            Console.WriteLine($"Has a Tail: {seaMonster.HasTail}");
            Console.WriteLine($"Can Fly: {seaMonster.CanFly}");
            Console.WriteLine($"Home Sea: {seaMonster.HomeSea}");
            Console.WriteLine($"Has Gills: {seaMonster.HasGills}");
            Console.WriteLine($"Lays Eggs: {seaMonster.LaysEggs}");
            Console.WriteLine($"Is Happy: {seaMonster.IsHappy()}");
            Console.WriteLine($"Is Hostile: {(seaMonster.IsHostile() ? "yes" : "no")}");
        }
        private static void DisplayDragonMonsterInfo(DragonMonster dragonMonster)
        {
            Console.WriteLine($"Id: {dragonMonster.Id}");
            Console.WriteLine($"Name: {dragonMonster.Name}");
            Console.WriteLine($"Age: {dragonMonster.Age}");
            Console.WriteLine($"Language: {dragonMonster.Language}");
            Console.WriteLine($"Weight: {dragonMonster.Weight}");
            Console.WriteLine($"Has a Tail: {dragonMonster.HasTail}");
            Console.WriteLine($"Can Fly: {dragonMonster.CanFly}");
            Console.WriteLine($"Is Happy: {(dragonMonster.IsHappy() ? "yes" : "no") }");
            Console.WriteLine($"Is Hostile: {(dragonMonster.IsHostile() ? "yes" : "no")}");
            Console.WriteLine($"Color: {dragonMonster.Color}");
            Console.WriteLine($"Breath Attack Element: {dragonMonster.BreathElement}");
            Console.WriteLine($"Has Treasure: {dragonMonster.HasTreasure}");
            Console.WriteLine($"Alignment: {dragonMonster.DragonCivilAlignment}/{dragonMonster.DragonMoralAlignment}");

            Console.WriteLine($"You attacked {dragonMonster.Name} and they {dragonMonster.MonsterBattleResponse()}");
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
