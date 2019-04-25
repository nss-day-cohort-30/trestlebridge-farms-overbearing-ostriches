using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseSeeds
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Sunflower Seeds");
            Console.WriteLine("2. Wildflower Seeds");
            Console.WriteLine("3. Sesame Seeds");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();
        try
        {
            switch (Int32.Parse(choice))
            {
<<<<<<< HEAD
                case 1:
                    ChooseAmountOfSeeds.CollectInput(farm);
                    break;
=======
                // case 1:
                //     ChooseSunflowerPlantingField.CollectInput(farm, new Sunflower());
                //     break;
>>>>>>> master
                case 2:
                    ChooseNaturalPlantingField.CollectInput(farm, new Wildflower());
                    break;
                case 3:
                    ChoosePlowedPlantingField.CollectInput(farm, new Sesame());
                    break;
                default:
                    break;

            }
        }
        catch(FormatException ex)
        {
            Console.WriteLine(@"
                **** That is not a valid Seed Choice ****
            ****     Press Enter To Return to Main Menu      ****");
            Console.ReadLine();
        }

        }
    }
}