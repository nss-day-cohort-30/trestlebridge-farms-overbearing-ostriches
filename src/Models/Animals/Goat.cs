using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Classes;

namespace Trestlebridge.Models.Animals
{
    public class Goat : Animal, IResource, IGrazing, IMeatProducing
    {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 7.5;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = 6.3;
        public string Type { get; } = "Goat";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Goat {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Goat {this._shortId}. Baaaaa!";
        }
    }
}