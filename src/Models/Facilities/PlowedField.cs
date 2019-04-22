using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IAgriculturalField, IPlantFacility<IPlowedFieldFlower>
    {
        private int _capacity = 13;
        private Guid _id = Guid.NewGuid();

        private List<IPlowedFieldFlower> _plowedFieldFlower= new List<IPlowedFieldFlower>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IPlowedFieldFlower plant)
        {
            if (_plowedFieldFlower.Count < _capacity)
            {
                _plowedFieldFlower.Add(plant);
            }
        }

        public void AddResource(List<IPlowedFieldFlower> plants)  // TODO: Take out this method for boilerplate
        {
            if (_plowedFieldFlower.Count + plants.Count <= _capacity)
            {
                _plowedFieldFlower.AddRange(plants);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._plowedFieldFlower.Count} plants\n");
            this._plowedFieldFlower.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}