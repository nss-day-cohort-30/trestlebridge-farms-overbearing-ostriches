using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Trestlebridge.Classes
{
    public class StorageFacility<T>
    {

        //a list of all resources that have been processed.
        public List<T> ResourceList = new List<T>();
        private string _capacity;

        public string listResources()
        {
            // Console.WriteLine($"({ResourceList.Count} animals out of {this._capacity})");
            Dictionary<string, Int32> resourceReport = new Dictionary<string, Int32>();
            foreach (T resource in this.ResourceList)
            {
                string type = resource.GetType().Name.ToString();
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
                if (kvp.Key != "Sheep" & kvp.Value >= 2)
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