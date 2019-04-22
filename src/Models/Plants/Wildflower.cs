using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ICompostProducing, INaturalFieldFlower
    {
    
        public string Type { get; } = "Wildflower";

        public double _compostProduced = 30.3;

        public double Compost () {
            return _compostProduced;
        }

        public override string ToString () {
            return $"Sesame. Yum!";
        }
    }
}