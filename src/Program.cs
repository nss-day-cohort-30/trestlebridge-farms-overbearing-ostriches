using System;
using System.Linq;
using Trestlebridge.Actions;
using Trestlebridge.Models;

namespace Trestlebridge
{
    class Program
    {

        //a method to create a banner for trestlebridge farms
        static void DisplayBanner()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(@"
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
        |T||r||e||s||t||l||e||b||r||i||d||g||e|
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
                    |F||a||r||m||s|
                    +-++-++-++-++-+");
            Console.WriteLine();
        }

        static void Main(string[] args)
        //sets the console color
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            Farm Trestlebridge = new Farm();

            while (true)
            {
                // displays the banner that was created above 
                DisplayBanner();
                // display all of the options to the user
                Console.WriteLine("1. Create Facility");
                Console.WriteLine("2. Purchase Animals");
                Console.WriteLine("3. Purchase Seeds");
                Console.WriteLine("4. Processing Options");
                Console.WriteLine("5. Display Farm Status");
                Console.WriteLine("6. Exit");
                Console.WriteLine();

                Console.WriteLine("Choose a FARMS option");
                Console.Write("> ");
                string option = Console.ReadLine();

                //if this option is selected the user will be brought to the facility purchasing screen
                if (option == "1")
                {
                    DisplayBanner();
                    CreateFacility.CollectInput(Trestlebridge);
                }

                //if this option is selected the user will be brought to the animal purchasing screen
                else if (option == "2")
                {
                    DisplayBanner();
                    PurchaseStock.CollectInput(Trestlebridge);
                }

                //if this option is selected the user will be brought to the seed purchasing string 
                else if (option == "3")
                {
                    DisplayBanner();
                    PurchaseSeeds.CollectInput(Trestlebridge);

                }


                else if (option == "4")
                {
                    DisplayBanner();
                    ProcessingOption.CollectInput(Trestlebridge);

                }

                //if this option is selected the user will be brought to a screen that displays all facilities, animals, and plants on the farm
                else if (option == "5")
                {
                    DisplayBanner();
                    Console.WriteLine(Trestlebridge);
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                }

                // The weak soul can no longer farm. This option allows you to leave your homestead
                else if (option == "6")
                {
                    Console.WriteLine("Today is a great day for farming");
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid option: {option}");
                }
            }
        }
    }
}
