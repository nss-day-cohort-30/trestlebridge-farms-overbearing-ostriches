using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Trestlebridge.Classes
{
    public class Facility<T>
    {

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
                if (i == 1)
                {
                    sb.Append(", ");
                }
                sb.Append(kvp.Value);
                sb.Append(" ");
                sb.Append(kvp.Key.ToLower());
                if (i >= 1)
                {
                    sb.Append(", ");
                }

            }
            // foreach (var kvp in resourceReport)
            // {
            //     sb.Append(kvp.Value);
            //     sb.Append(" ");
            //     sb.Append(kvp.Key.ToLower());
            //     sb.Append(", ");
            // }

            Console.WriteLine(sb.ToString());
            return (sb.ToString());
        }



    }
}