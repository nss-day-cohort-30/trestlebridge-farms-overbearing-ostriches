using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;

namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IAnimalFacility<IGrazing>, IFacility
    {
        private int _capacity = 5;
        private Guid _id = Guid.NewGuid();

        public List<IGrazing> _grazingAnimalList = new List<IGrazing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public void listAnimals()
        {
            Console.WriteLine($"({_grazingAnimalList.Count} animals out of {this._capacity})");
            // List<IGrazing> list = new List<IGrazing>();
            Dictionary<IGrazing, Int32> animalReport = new Dictionary<IGrazing, Int32>();
            foreach (IGrazing grazingAnimal in this._grazingAnimalList)
            {
                var type = grazingAnimal.GetType();
                // if (animalReport.ContainsKey(ty();))

                Console.WriteLine(grazingAnimal.GetType().Name);
            }

        }

        public void AddAnimalResource(IGrazing animal)
        {
            if (_grazingAnimalList.Count >= _capacity)
            {
                Console.WriteLine(@"
        **** That facililty is not large enough ****
        ****     Please choose another one      ****");
                Console.ReadLine();
            }
            else if (_grazingAnimalList.Count < _capacity)
            {
                _grazingAnimalList.Add(animal);
            }
        }

        public void AddAnimalResource(List<IGrazing> animals)  // TODO: Take out this method for boilerplate
        {
            if (_grazingAnimalList.Count + animals.Count <= _capacity)
            {
                _grazingAnimalList.AddRange(animals);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._grazingAnimalList.Count} animals\n");
            this._grazingAnimalList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}