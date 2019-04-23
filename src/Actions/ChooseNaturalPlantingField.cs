using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Classes;

namespace Trestlebridge.Actions
{

    public class ChooseNaturalPlantingField
    {
        public static void CollectInput(Farm farm, INaturalFieldFlower naturalFlower)
        {
            Console.Clear();

            for (int i = 0; i < farm.NaturalFieldList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field");
            }

            Console.WriteLine();

            Console.WriteLine($"Plant the seed where?");

            Console.WriteLine("> ");
            int choice = Int32.Parse(Console.ReadLine());

            choice = choice - 1;
            farm.NaturalFieldList[choice].AddPlantResource(naturalFlower);
        }
    }
}