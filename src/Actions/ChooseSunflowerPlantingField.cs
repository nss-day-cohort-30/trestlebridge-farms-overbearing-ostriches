using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions {

public class ChooseSunflowerPlantingField {
    public static void CollectInput(Farm farm, ISunflowerPlantFacility SunflowerField)
    {
        Console.Clear();

        for (int i =0; i < farm.PlantFacilityList.Count; i++)
        {var field = farm.PlantFacilityList[i];
        {
            Console.WriteLine($"{i + 1}. {field.GetType().Name} ");
        }
        }
        Console.WriteLine();

        Console.WriteLine($"Plant the seed where?");

        Console.WriteLine("> ");
        int choice = Int32.Parse(Console.ReadLine());

        choice = choice - 1;
        // farm.PlantFacilityList[choice].AddPlantResource(SunflowerField);
        }
    }
}