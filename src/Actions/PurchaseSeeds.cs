using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseSeeds
    {
        public static void CollectInput(Farm farm)
        {
            //List out the seeds that can be purchased 

            Console.WriteLine("1. Sunflower Seeds");
            Console.WriteLine("2. Wildflower Seeds");
            Console.WriteLine("3. Sesame Seeds");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();


            //Choose the seed you wish to purchase
            string chosenType;
            if (choice == "1")
            {
                chosenType = "Sunflower";
            }
            else if (choice == "2")
            {
                chosenType = "Wildflower";
            }
            else if (choice == "3")
            {
                chosenType = "Sesame";
            }
            else
            {
                chosenType = "";

            }
            //The try catch will stop the error if an invalid option is inputed and send the user back to the main menu
            try
            {
                //Grabs the users selection and displays the next relevant page
                switch (Int32.Parse(choice))
                {
                    case 1:
                        ChooseAmountOfSeeds.CollectInput(farm, chosenType);
                        break;
                    case 2:
                        ChooseAmountOfSeeds.CollectInput(farm, chosenType);
                        break;
                    case 3:
                        ChooseAmountOfSeeds.CollectInput(farm, chosenType);
                        break;
                    default:
                        break;

                }
            }
            //the catch that will display instructins to the user 
            catch (FormatException ex)
            {
                Console.WriteLine(@"
                **** That is not a valid Seed Choice ****
            ****     Press Enter To Return to Main Menu      ****");
                Console.ReadLine();
            }
        }
    }
}