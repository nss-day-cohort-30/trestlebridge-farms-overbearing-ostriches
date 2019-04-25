using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Classes;
using Trestlebridge.Models.Plants;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : StorageFacility<IPlowedFieldFlower>, IPlantFacility<IPlowedFieldFlower>, IFacility, ISunflowerPlantFacility
    {
        private int _capacity = 13;
        private Guid _id = Guid.NewGuid();

        private List<IPlowedFieldFlower> _plowedFieldFlowerList = new List<IPlowedFieldFlower>();

        public List<Plant> plantList = new List<Plant>();

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
                ResourceList.Add(plant);
            }
        }

        public void AddPlantResource(Sunflower plant)
        {
            if (_plowedFieldFlowerList.Count < _capacity)
            {
                _plowedFieldFlowerList.Add(plant);
                ResourceList.Add(plant);
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