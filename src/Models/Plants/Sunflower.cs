using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Classes;
using System.Collections.Generic;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : Plant, IResource, ISeedProducing, ICompostProducing, IPlowedFieldFlower, INaturalFieldFlower
    {

        // holds the total amount of seeds this plant will produce 
        private int _seedsProduced = 650;

        //holds the type of the resource in this case it is a Sunflower
        public string Type { get; } = "Sunflower";


        // a method that returns the total amount of seeds produced 
        public double Harvest()
        {
            return _seedsProduced;
        }


        // holds the total amount of compost made 
        private double _compostProduced = 21.6;


        // a method that composts the flowers and returns the total amount of compost produced
        public double Compost()
        {
            return _compostProduced;
        }

        public override string ToString()
        {
            return $"Look: a Sunflower!";
        }

    }
}