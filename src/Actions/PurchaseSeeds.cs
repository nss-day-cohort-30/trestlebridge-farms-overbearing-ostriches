using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;

namespace Trestlebridge.Actions
{
    public class PurchaseSeeds
    {
        public static void CollectInput (Farm farm) {
            Console.WriteLine("1. Sunflower Seeds");
            Console.WriteLine("2. Wildflower Seeds");
            Console.WriteLine("3. Sesame Seeds");

            Console.WriteLine ();
            Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            string choice = Console.ReadLine ();
        }
    }
}