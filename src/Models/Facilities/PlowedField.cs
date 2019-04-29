using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Classes;
using Trestlebridge.Models.Plants;
using System.Linq;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : StorageFacility<IPlowedFieldFlower>, IPlantFacility<IPlowedFieldFlower>, IFacility, ISunflowerPlantFacility
    {

        //list the total capacity of the plowed fields 
        private int _capacity = 13;
        private Guid _id = Guid.NewGuid();


        //a list that accepts all plants with the interface of IPlowedFieldFlower
        private List<IPlowedFieldFlower> _plowedFieldFlowerList = new List<IPlowedFieldFlower>();

        //A list of plants 
        public List<Plant> plantList = new List<Plant>();


        //returns the total capacity of the plowed field
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public bool checkCapacity(Farm farm)
        {
            var plowedFieldList = farm.PlowedFieldList;
            if (this.Capacity > _plowedFieldFlowerList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //adds plant resources to the plowed field list 
        public void AddPlantResource(IPlowedFieldFlower plant)
        {
            if (_plowedFieldFlowerList.Count < _capacity)
            {
                _plowedFieldFlowerList.Add(plant);
                ResourceList.Add(plant);
            }
        }


        //sunflowers needing there own add method again 
        public void AddPlantResource(Sunflower plant)
        {
            if (_plowedFieldFlowerList.Count < _capacity)
            {
                _plowedFieldFlowerList.Add(plant);
                ResourceList.Add(plant);
            }
        }

        public void AddPlantResource(List<IPlowedFieldFlower> plants)  // TODO: Take out this method for boilerplate
        {
            if (_plowedFieldFlowerList.Count + plants.Count <= _capacity)
            {
                _plowedFieldFlowerList.AddRange(plants);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._plowedFieldFlowerList.Count} plants\n");
            this._plowedFieldFlowerList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
        public string listPlowedFieldFlowers()
        {
            Dictionary<string, Int32> resourceReport = new Dictionary<string, Int32>();
            foreach (IPlowedFieldFlower flower in this._plowedFieldFlowerList)
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
                sb.Append("row");
                 if ( kvp.Value >= 2)
                {
                    sb.Append("s");
                }
                sb.Append(" of ");
                sb.Append(kvp.Key.ToLower());
                if (kvp.Key != "Sesame") 
                {
                sb.Append("s");
                }
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