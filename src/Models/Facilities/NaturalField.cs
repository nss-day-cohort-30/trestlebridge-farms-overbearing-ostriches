using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IPlantFacility<INaturalFieldFlower>, IFacility
    {
        private int _capacity = 10;
        private Guid _id = Guid.NewGuid();

        private List<INaturalFieldFlower> _naturalFieldFlowerList = new List<INaturalFieldFlower>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddPlantResource(INaturalFieldFlower flower)
        {
            if (_naturalFieldFlowerList.Count < _capacity)
            {
                _naturalFieldFlowerList.Add(flower);
            }
        }

        public void AddPlantResource(List<INaturalFieldFlower> flowers)  // TODO: Take out this method for boilerplate
        {
            if (_naturalFieldFlowerList.Count + flowers.Count <= _capacity)
            {
                _naturalFieldFlowerList.AddRange(flowers);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._naturalFieldFlowerList.Count} animals\n");
            this._naturalFieldFlowerList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}