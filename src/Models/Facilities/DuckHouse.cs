using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;
using Trestlebridge.Classes;


namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : StorageFacility<Duck>, IAnimalFacility<Duck>, IFacility
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
        public void AddAnimalResource(Duck animal)
        {
            if (_duckList.Count >= _capacity)
            {
                Console.WriteLine(@"
        **** That facililty is not large enough ****
        ****     Please choose another one      ****");
                Console.ReadLine();
            }
            else if (_duckList.Count < _capacity)
            {
                _duckList.Add(animal);
                ResourceList.Add(animal);
            }
        }

        public void AddAnimalResource(List<Duck> animals)  // TODO: Take out this method for boilerplate
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

            output.Append($"Duck House {shortId} has {this._duckList.Count} ducks\n");
            this._duckList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}