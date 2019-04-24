using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;
using Trestlebridge.Classes;


namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : Facility<Chicken>, IAnimalFacility<Chicken>, IFacility
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
            if (_chickenList.Count >= _capacity)
            {
                Console.WriteLine(@"
        **** That facililty is not large enough ****
        ****     Please choose another one      ****");
                Console.ReadLine();
            }
            else if (_chickenList.Count < _capacity)
            {
                _chickenList.Add(animal);
                ResourceList.Add(animal);
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

            output.Append($"Grazing field {shortId} has {this._chickenList.Count} animals\n");
            this._chickenList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}