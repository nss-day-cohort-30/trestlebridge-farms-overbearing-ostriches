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

        private List<IPlowedFieldFlower> _plowedFieldFlowerList = new List<IPlowedFieldFlower>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddPlantResource(IPlowedFieldFlower plant)
        {
            if (_plowedFieldFlowerList.Count < _capacity)
            {
                _plowedFieldFlowerList.Add(plant);
            }
        }

        public void AddPlantResource(List<IPlowedFieldFlower> plants)  // TODO: Take out this method for boilerplate
        {
            if (_plowedFieldFlowerList.Count + plants.Count <= _capacity)
            {
                _plowedFieldFlowerList.AddRange(plants);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._plowedFieldFlowerList.Count} plants\n");
            this._plowedFieldFlowerList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}