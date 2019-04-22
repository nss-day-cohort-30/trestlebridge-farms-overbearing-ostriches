using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IPlantFacility<IPlowedFieldFlower>, IFacility
    {
        private int _capacity = 13;
        private Guid _id = Guid.NewGuid();

        private List<IPlowedFieldFlower> _animals = new List<IPlowedFieldFlower>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddPlantResource(IPlowedFieldFlower animal)
        {
            if (_animals.Count < _capacity)
            {
                _animals.Add(animal);
            }
        }

        public void AddPlantResource(List<IPlowedFieldFlower> animals)  // TODO: Take out this method for boilerplate
        {
            if (_animals.Count + animals.Count <= _capacity)
            {
                _animals.AddRange(animals);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}