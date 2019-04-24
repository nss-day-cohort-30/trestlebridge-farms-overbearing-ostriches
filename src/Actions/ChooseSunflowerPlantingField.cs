using System;
using System.Linq;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Classes;

namespace Trestlebridge.Actions
{

    public class ChooseSunflowerPlantingField
    {
        public static void CollectInput(Farm farm, List<Plant> sunflowerList)
        {
            Console.Clear();

            for (int i = 0; i < farm.PlantFacilityList.Count; i++)
            {
                var sunflowerField = farm.PlantFacilityList[i];
                {
                    Console.WriteLine($"{i + 1}. {sunflowerField.GetType().Name} ");
                    // sunflowerField.listResources();
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Plant the seed where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());



            choice = choice - 1;
            dynamic chosenField = farm.PlantFacilityList[choice];
            
            chosenField.AddPlantResource(sunflowerList);
        }
    }
}
