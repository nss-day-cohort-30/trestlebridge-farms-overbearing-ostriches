using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseAmountOfSeeds
    {
        public static void CollectInput(Farm farm)
        {
            Console.Clear();


            Console.WriteLine("How many seeds would you like to plant?");

            Console.Write("> ");


            List<IPlowedFieldFlower> sunflowerList = new List<IPlowedFieldFlower>();
            int choice = Int32.Parse(Console.ReadLine());
           

            for (int i = 0; i < choice; i++)
            {
                 sunflowerList.Add(new Sunflower());
            }

            ChooseSunflowerPlantingField.CollectInput(farm, sunflowerList);
        }
    }
}
