using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{

    public class ChoosePlowedPlantingField
    {
        public static void CollectInput(Farm farm, IPlowedFieldFlower PlowedFieldFlower)
        {
            Console.Clear();

            for (int i = 0; i < farm.PlowedFieldList.Count; i++)
            {
                var plowedField = farm.PlowedFieldList[i];
                Console.WriteLine($"{i + 1}. Plowed Field");
                plowedField.listResources();
            }

            Console.WriteLine();

            Console.WriteLine($"Plant the seed where?");

            Console.WriteLine("> ");
            int choice = Int32.Parse(Console.ReadLine());

            choice = choice - 1;
            farm.PlowedFieldList[choice].AddPlantResource(PlowedFieldFlower);
        }
    }
}