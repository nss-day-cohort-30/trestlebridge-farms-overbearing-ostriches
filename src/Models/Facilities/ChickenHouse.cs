using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;


namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IAnimalFacility<Chicken>, IFacility
    {
        private int _capacity = 15;
        private Guid _id = Guid.NewGuid();

        private List<Chicken> _chickenHouseList = new List<Chicken>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddAnimalResource(Chicken animal)
        {
            if (_chickenHouseList.Count < _capacity)
            {
                _chickenHouseList.Add(animal);
            }
        }

        public void AddAnimalResource(List<Chicken> animals)  // TODO: Take out this method for boilerplate
        {
            if (_chickenHouseList.Count + animals.Count <= _capacity)
            {
                _chickenHouseList.AddRange(animals);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken house {shortId} has {this._chickenHouseList.Count} animals\n");
            this._chickenHouseList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}