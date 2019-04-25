using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using System.Collections.Generic;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedPlantingField
    {
        public static void CollectInput(Farm farm, List<Sesame> sesameSeeds)
        {
            Console.Clear();

            for (int i = 0; i < farm.PlowedFieldList.Count; i++)
            {
                dynamic sesameSeedField = farm.PlantFacilityList[i];
                {
                    Console.WriteLine($"{i + 1}. {sesameSeedField.GetType().Name} ");
                    sesameSeedField.listResources();
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Plant the seed where?");

            Console.WriteLine("> ");
            int choice = Int32.Parse(Console.ReadLine());

            choice = choice - 1;
            dynamic chosenField = farm.PlantFacilityList[choice];

            var sesameSeedsForPlowedField = sesameSeeds.Cast<IPlowedFieldFlower>().ToList();
            chosenField.AddPlantResource(sesameSeedsForPlowedField);
        }
    }
}