using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ProcessingOption
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Seed Harvest");
            Console.WriteLine("2. Meat Processor");
            Console.WriteLine("3. Egg Gatherer");
            Console.WriteLine("4. Composter");
            Console.WriteLine("5. Feather Harvester");


            Console.WriteLine();
            Console.WriteLine("What are you processing today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            try
            {
                switch (Int32.Parse(choice))
                {
                    case 1:
                        ChooseGrazingField.CollectInput(farm, new Cow());
                        break;
                    case 2:
                        ChooseGrazingField.CollectInput(farm, new Ostrich());
                        break;
                    case 3:
                        ChooseGrazingField.CollectInput(farm, new Sheep());
                        break;
                    case 4:
                        ChooseGrazingField.CollectInput(farm, new Goat());
                        break;
                    case 5:
                        ChooseGrazingField.CollectInput(farm, new Pig());
                        break;
                    // default:
                }
            }
            catch(FormatException ex )
            {
                        Console.WriteLine(@"
                    **** That is not a valid Processing Option ****
                ****     Press Enter To Return to Main Menu      ****");
                        Console.ReadLine();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                        Console.WriteLine(@"
                    **** That is not a valid Processing Option ****
                ****     Press Enter To Return to Main Menu      ****");
                        Console.ReadLine();
            }
        }
    }
}