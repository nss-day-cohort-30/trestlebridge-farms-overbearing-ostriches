using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using System.Collections;
using System.Collections.Generic;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Classes;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Console.Clear();
            //For Loop, loops through entire GrazingField List
            for (int i = 0; i < farm.GrazingFieldList.Count; i++)
            {
                {   //Loops through ever individual field in GrazingFieldList
                    //Individual fields are stored in the variable grazingField
                    var grazingField = farm.GrazingFieldList[i];
                    //If the logic of checkCapacity boolean method is true the field is shown
                    if (grazingField.checkCapacity(farm)== true)
                    {
                        Console.WriteLine($"{i + 1}. Grazing Field");
                        grazingField.listAnimals();
                    }
                Hashtable ht = new Hashtable();
                }
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the {animal.GetType().Name.ToLower()} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            //Index had to subtracted. The reason is because the input does not actually
            //equal the index position of the field
            choice = choice - 1;

            farm.GrazingFieldList[choice].AddAnimalResource(animal);
            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }


    }
}
