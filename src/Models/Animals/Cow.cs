using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Classes;

namespace Trestlebridge.Models.Animals
{
    public class Cow : Animal, IResource, IGrazing, IMeatProducing
    {
            // hexadecimal string given to each individual chicken
        private Guid _id = Guid.NewGuid();

        // holds the amount of product produced after processing 
         private double _meatProduced = 18.25;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
            //holds how much grass a cow can eat in a day
        public double GrassPerDay { get; set; } = 5.4;
        public string Type { get; } = "Cow";

        // Methods

        // method to display the cow eating
        public void Graze()
        {
            Console.WriteLine($"Cow {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        // method that allows the cow to be butcherd and collect the meat
        public double Butcher()
        {
            return _meatProduced;
        }

        // makes the cow moo
        public override string ToString()
        {
            return $"Cow {this._shortId}. Mooo!";
        }
    }
}