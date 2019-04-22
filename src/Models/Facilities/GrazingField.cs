using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _grazingAnimalList = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IGrazing animal)
        {
            if (_grazingAnimalList.Count < _capacity) {
                _grazingAnimalList.Add(animal);
            }
        }

        public void AddResource (List<IGrazing> animals)  // TODO: Take out this method for boilerplate
        {
            if (_grazingAnimalList.Count + animals.Count <= _capacity) {
                _grazingAnimalList.AddRange(animals);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._grazingAnimalList} animals\n");
            this._grazingAnimalList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}