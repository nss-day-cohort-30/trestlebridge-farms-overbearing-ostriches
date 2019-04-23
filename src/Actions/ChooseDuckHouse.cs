using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, Duck duck)
        {
            Console.Clear();

            for (int i = 0; i < farm.DuckHouseList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Duck House");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            //Index had to subtracted. The reason is because the input does not actually
            //equal the index position of the field
            choice = choice - 1;
            farm.DuckHouseList[choice].AddAnimalResource(duck);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}