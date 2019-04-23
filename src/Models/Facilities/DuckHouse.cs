using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;


namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IAnimalFacility<Duck>, IFacility
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<Duck> _duckHouseList = new List<Duck>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddAnimalResource(Duck animal)
        {
            if (_duckHouseList.Count < _capacity)
            {
                _duckHouseList.Add(animal);
            }
        }

        public void AddAnimalResource(List<Duck> animals)  // TODO: Take out this method for boilerplate
        {
            if (_duckHouseList.Count + animals.Count <= _capacity)
            {
                _duckHouseList.AddRange(animals);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck house {shortId} has {this._duckHouseList.Count} animals\n");
            this._duckHouseList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}