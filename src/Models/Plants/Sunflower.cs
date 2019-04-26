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

        public double Harvest()
        {
            return _seedsProduced;
        }

        private double _compostProduced = 21.6;

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