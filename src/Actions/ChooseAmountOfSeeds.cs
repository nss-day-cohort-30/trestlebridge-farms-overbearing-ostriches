using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Classes;

namespace Trestlebridge.Actions
{
    public class ChooseAmountOfSeeds
    {
        public static void CollectInput(Farm farm, string chosenType)
        {
            Console.Clear();


            Console.WriteLine("How many seeds would you like to plant?");

            Console.Write("> ");

            //creates a list of seeds to be added to the fields

            if (chosenType == "Sunflower")
            {

                List<Sunflower> sunflowerList = new List<Sunflower>();
                int choice = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < choice; i++)
                {
                    sunflowerList.Add(new Sunflower());
                }

                ChooseSunflowerPlantingField.CollectInput(farm, sunflowerList);
            }
        }
    }
}
