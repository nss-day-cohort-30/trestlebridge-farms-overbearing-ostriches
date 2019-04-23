using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Classes;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : Plant, IResource, ICompostProducing, INaturalFieldFlower
    {

        public string Type { get; } = "Wildflower";

        public double _compostProduced = 30.3;

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