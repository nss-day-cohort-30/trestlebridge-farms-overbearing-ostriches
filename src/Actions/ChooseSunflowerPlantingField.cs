// using System;
// using System.Linq;
// using Trestlebridge.Interfaces;
// using Trestlebridge.Models;
// using Trestlebridge.Models.Plants;

// namespace Trestlebridge.Actions
// {

//     public class ChooseSunflowerPlantingField
//     {
//         public static void CollectInput(Farm farm, Sunflower sunflower)
//         {
//             Console.Clear();

//             for (int i = 0; i < farm.PlantFacilityList.Count; i++)
//             {
//                 var sunflowerField = farm.PlantFacilityList[i];
//                 {
//                     Console.WriteLine($"{i + 1}. {sunflowerField.GetType().Name} ");
//                     // sunflowerField.listResources();
//                 }
//             }
//             Console.WriteLine();

//             Console.WriteLine($"Plant the seed where?");

//             Console.WriteLine("> ");
//             int choice = Int32.Parse(Console.ReadLine());

//             choice = choice - 1;
//             farm.PlantFacilityList[choice].AddPlantResource(sunflower);
//         }
//     }
// }
