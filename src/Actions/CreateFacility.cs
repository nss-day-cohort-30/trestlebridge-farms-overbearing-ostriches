using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");
            Console.WriteLine("3. Natural field");
            Console.WriteLine("4. Chicken House");
            Console.WriteLine("5. Duck House");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();
        //This try catch was added due to the fact that if you don't select a facility
        //and just hit enter/return the program would crash
        try
        {

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    break;
                case 2:
                    farm.AddPlowedField(new PlowedField());
                    break;
                case 3:
                    farm.AddNaturalField(new NaturalField());
                    break;
                case 4:
                    farm.AddChickenHouse(new ChickenHouse());
                    break;
                case 5:
                    farm.AddDuckHouse(new DuckHouse());
                    break;
            }
                    // default:
        }
        catch (FormatException ex)
        {
            Console.WriteLine(@"
                **** That is not a valid Facility Choice ****
            ****     Press Enter To Return to Main Menu      ****");
                    Console.ReadLine();
        }

        }
    }
}