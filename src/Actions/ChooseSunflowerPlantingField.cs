using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Classes;
using System.Collections.Generic;
using Trestlebridge.Models.Facilities;


namespace Trestlebridge.Actions
{

    public class ChooseSunflowerPlantingField
    {
        public static void CollectInput(Farm farm, List<Sunflower> sunflowers)
        {
            Console.Clear();

            for (int i = 0; i < farm.PlantFacilityList.Count; i++)
            // sunflowerField may be Natural or Plowed Field
            {
                dynamic sunflowerField = farm.PlantFacilityList[i];
                // if (sunflowers.Capacity <= farm.PlantFacilityList.Capacity)
                //  {
                //  }
                {
                    Console.WriteLine($"{i + 1}. {sunflowerField.GetType().Name} ");
                    sunflowerField.listResources();
                }
            }
            Console.WriteLine();

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Plant the seed where?");

            choice = choice - 1;

            dynamic chosenField = farm.PlantFacilityList[choice];

            //lets the user plant sunflowers in plowed or natural fields 
            if (chosenField is NaturalField)
            {
                var sunflowersForNaturalField = sunflowers.Cast<INaturalFieldFlower>().ToList();
                chosenField.AddPlantResource(sunflowersForNaturalField);
            }
            else
            {
                var sunflowersForPlowedField = sunflowers.Cast<IPlowedFieldFlower>().ToList();
                chosenField.AddPlantResource(sunflowersForPlowedField);
            }
        }
    }
}

