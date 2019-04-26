using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Classes;

namespace Trestlebridge.Models.Plants
{
    public class Sesame : Plant, IResource, ISeedProducing, IPlowedFieldFlower
    {

        //holds the amount of seeds this plant will produce
        private int _seedsProduced = 520;


        //holds the type of the resource in this case it is a sesame seed
        public string Type { get; } = "Sesame";

        //method to harvest seeds and return the _seedsProduced
        public double Harvest()
        {
            return _seedsProduced;
        }

        public override string ToString()
        {
            return $"Sesame. Yum!";
        }
    }
}