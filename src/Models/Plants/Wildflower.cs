using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Classes;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : Plant, IResource, ICompostProducing, INaturalFieldFlower
    {
            //holds the type of the resource in this case it is a wildflower
        public string Type { get; } = "Wildflower";


        //holds the total amount of compost produced
        public double _compostProduced = 30.3;


        //a method that returns the total amount of compost produced by this plant
        public double Compost()
        {
            return _compostProduced;
        }

        public override string ToString()
        {
            return $"Wildflower";
        }
    }
}