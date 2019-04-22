using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;


namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<Duck>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<Duck> _duckList = new List<Duck>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(Duck animal)
        {
            if (_duckList.Count < _capacity)
            {
                _duckList.Add(animal);
            }
        }

        public void AddResource(List<Duck> animals)  // TODO: Take out this method for boilerplate
        {
            if (_duckList.Count + animals.Count <= _capacity)
            {
                _duckList.AddRange(animals);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._duckList.Count} animals\n");
            this._duckList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}