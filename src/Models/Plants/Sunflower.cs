using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Classes;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : Plant, IResource, ISeedProducing, ICompostProducing, IPlowedFieldFlower, INaturalFieldFlower, ISunflowerPlantFacility
    {
        private int _seedsProduced = 650;
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

<<<<<<< HEAD
        public override string ToString()
        {
            return $"Sunflower!";
=======
        public override string ToString () {
            return $"Look a Sunflower!";
>>>>>>> 51e6761e52e8b6e7eb1458ae4a683acd83fb17db
        }
    }
}