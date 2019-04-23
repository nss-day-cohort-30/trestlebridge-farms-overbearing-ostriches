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

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseNaturalPlantingField.CollectInput(farm, new Sunflower());
                    break;
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
    }
}