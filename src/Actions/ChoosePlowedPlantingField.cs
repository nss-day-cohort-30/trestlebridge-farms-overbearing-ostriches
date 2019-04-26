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
            //loops through all plowed fields and lists them
            for (int i = 0; i < farm.PlowedFieldList.Count; i++)
            {
                 dynamic sesameSeedField = farm.PlowedFieldList[i];
                 if(sesameSeedField.checkCapacity(farm) == true)
                {
                    Console.WriteLine($"{i + 1}. {sesameSeedField.GetType().Name} ");
                    sesameSeedField.listResources();
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Plant the seed where?");

            Console.WriteLine("> ");
            // takes the users input and turns it into an int
            int choice = Int32.Parse(Console.ReadLine());

            // uses the users input to select which farm to plant at
            choice = choice - 1;
            try
            {
            dynamic chosenField = farm.PlantFacilityList[choice];

            //changes the type of the list of seeds to allow them to be planted
            var sesameSeedsForPlowedField = sesameSeeds.Cast<IPlowedFieldFlower>().ToList();

            chosenField.AddPlantResource(sesameSeedsForPlowedField);
            }catch (FormatException ex)
            {
                Console.WriteLine(@"
                **** That is not a valid Field Choice ****
            ****     Press Enter To Return to Main Menu      ****");
                Console.ReadLine();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(@"
                **** That is not a valid Field Choice ****
            ****     Press Enter To Return to Main Menu      ****");
                Console.ReadLine();
            }
        }
    }
}