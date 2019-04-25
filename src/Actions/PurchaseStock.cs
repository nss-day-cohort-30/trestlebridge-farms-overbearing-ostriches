using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseStock
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Cow");
            Console.WriteLine("2. Ostrich");
            Console.WriteLine("3. Sheep");
            Console.WriteLine("4. Goat");
            Console.WriteLine("5. Pig");
            Console.WriteLine("6. Chicken");
            Console.WriteLine("7. Duck");


            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();
        try
        {

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                // default:
            }
        }
        catch(FormatException ex )
        {
                    Console.WriteLine(@"
                **** That is not a valid Animal Choice ****
            ****     Press Enter To Return to Main Menu      ****");
                    Console.ReadLine();
        }
        catch(ArgumentOutOfRangeException ex)
        {
                    Console.WriteLine(@"
                **** That is not a valid Animal Choice ****
            ****     Press Enter To Return to Main Menu      ****");
                    Console.ReadLine();
        }

        }
    }
}