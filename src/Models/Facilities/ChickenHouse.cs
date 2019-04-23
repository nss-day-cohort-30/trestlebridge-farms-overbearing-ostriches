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

        private List<Chicken> _chickenList = new List<Chicken>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddAnimalResource(Chicken animal)
        {
            if (_chickenList.Count < _capacity)
            {
                _chickenList.Add(animal);
            }
        }

        public void AddAnimalResource(List<Chicken> animals)  // TODO: Take out this method for boilerplate
        {
            if (_chickenList.Count + animals.Count <= _capacity)
            {
                _chickenList.AddRange(animals);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken House {shortId} has {this._chickenList.Count} chickens\n");
            this._chickenList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}