using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Classes;
using Trestlebridge.Models.Plants;
using System.Linq;


namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : StorageFacility<INaturalFieldFlower>, IPlantFacility<INaturalFieldFlower>, IFacility, ISunflowerPlantFacility
    {
        private int _capacity = 10;
        private Guid _id = Guid.NewGuid();

        private List<INaturalFieldFlower> _naturalFieldFlowerList = new List<INaturalFieldFlower>();

        public List<Plant> plantList = new List<Plant>();

        public int Capacity
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
                ResourceList.Add(flower);
            }
        }

        public int checkCapacityLimit(Farm farm)
        {
            if (this.Capacity > _naturalFieldFlowerList.Count)
            {
                 int capacityLimit = this.Capacity - _naturalFieldFlowerList.Count;
            }
        }

        public void AddPlantResource(Sunflower sunflower)
        {
            if (_naturalFieldFlowerList.Count < _capacity)
            {
                _naturalFieldFlowerList.Add(sunflower);
                ResourceList.Add(sunflower);
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

            output.Append($"Natural field {shortId} has {this._naturalFieldFlowerList.Count} plants\n");
            this._naturalFieldFlowerList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }

        public string listNaturalFieldFlowers()
        {
            // Console.WriteLine($"({ResourceList.Count} animals out of {this._capacity})");
            Dictionary<string, Int32> resourceReport = new Dictionary<string, Int32>();
            foreach (INaturalFieldFlower flower in this._naturalFieldFlowerList)
            {
                string type = flower.GetType().Name.ToString();
                int count;
                resourceReport.TryGetValue(type, out count);
                resourceReport[type] = count + 1;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < resourceReport.Count; i++)
            {
                var kvp = resourceReport.ElementAt(i);
                sb.Append(kvp.Value);
                sb.Append(" ");
                sb.Append(kvp.Key.ToLower());
                if (i != resourceReport.Count - 1)
                {
                    sb.Append(", ");
                }
            }
            Console.WriteLine(sb.ToString());
            return (sb.ToString());
        }
    }
}