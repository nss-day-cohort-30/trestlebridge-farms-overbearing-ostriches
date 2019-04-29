using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Classes;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : Animal, IResource, IMeatProducing
    {

        // hexadecimal string given to each individual chicken
        private Guid _id = Guid.NewGuid();

        // holds the amount of product produced after processing 
        private double _meatProduced = 1.7;


            // type holds what the animal is, in this case it is a chicken
        public string Type { get; } = "Chicken";

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }


            //a method that returns the total amount of meet produced after processing 
        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Chicken {this._shortId}. Cluck Cluck Cluck!";
        }
    }
}