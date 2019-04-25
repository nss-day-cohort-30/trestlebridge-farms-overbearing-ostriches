using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Classes;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<IFacility> FacilityList { get; } = new List<IFacility>();

        public List<GrazingField> GrazingFieldList { get; } = new List<GrazingField>();
        public List<PlowedField> PlowedFieldList { get; } = new List<PlowedField>();

        public List<ChickenHouse> ChickenHouseList { get; } = new List<ChickenHouse>();

        public List<DuckHouse> DuckHouseList { get; } = new List<DuckHouse>();

        public List<NaturalField> NaturalFieldList { get; } = new List<NaturalField>();

        public List<ISunflowerPlantFacility> PlantFacilityList { get; set; } = new List<ISunflowerPlantFacility>();

        public List<Plant> PlantList { get; set; } = new List<Plant>();

        /*
This method must specify the correct product interface of the
resource being purchased.
*/
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFieldList[index].AddAnimalResource((IGrazing)resource);
                    break;
                default:
                    break;
            }
        }
        public void AddGrazingField(GrazingField field)
        {
            GrazingFieldList.Add(field);
            FacilityList.Add(field);
        }

        public void AddPlowedField(PlowedField field)
        {
            PlowedFieldList.Add(field);
            FacilityList.Add(field);
            PlantFacilityList.Add(field);
        }
        public void AddDuckHouse(DuckHouse duckHouse)
        {
            DuckHouseList.Add(duckHouse);
            FacilityList.Add(duckHouse);
        }
        public void AddChickenHouse(ChickenHouse chickenHouse)
        {
            ChickenHouseList.Add(chickenHouse);
            FacilityList.Add(chickenHouse);
        }

        public void AddNaturalField(NaturalField naturalField)
        {
            NaturalFieldList.Add(naturalField);
            FacilityList.Add(naturalField);
            PlantFacilityList.Add(naturalField);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();
            // call listResources method on objects in interface list 
            for (int i = 0; i < FacilityList.Count; i++)
            {
                var facility = FacilityList[i];
                dynamic facilityAsClassType = Convert.ChangeType(facility, facility.GetType());
                Console.WriteLine($"{i + 1}. {facility.GetType().Name}");
                facilityAsClassType.listResources();

            };

            return report.ToString();
        }
    }
}