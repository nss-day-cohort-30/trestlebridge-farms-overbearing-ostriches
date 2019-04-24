using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Classes;

namespace Trestlebridge.Models.Plants
{
    public class Sesame : Plant, IResource, ISeedProducing, IPlowedFieldFlower
    {
        private int _seedsProduced = 520;
        public string Type { get; } = "Sesame";

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