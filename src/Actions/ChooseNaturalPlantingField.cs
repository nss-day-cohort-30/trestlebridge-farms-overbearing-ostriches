using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using System.Collections.Generic;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{

    public class ChooseNaturalPlantingField
    {
        public static void CollectInput(Farm farm, List<Wildflower> wildFlowers)
        {
            Console.Clear();

            for (int i = 0; i < farm.NaturalFieldList.Count; i++)
            {
                dynamic wildflowerField = farm.PlantFacilityList[i];
                {
                    Console.WriteLine($"{i + 1}. {wildflowerField.GetType().Name} ");
                    wildflowerField.listResources();
                }
            }

            Console.WriteLine();

            Console.WriteLine($"Plant the seed where?");

            Console.WriteLine("> ");
            int choice = Int32.Parse(Console.ReadLine());

            choice = choice - 1;
            dynamic chosenField = farm.NaturalFieldList[choice];

            var wildflowersForNaturalField = wildFlowers.Cast<INaturalFieldFlower>().ToList();
            chosenField.AddPlantResource(wildflowersForNaturalField);
        }
    }
}