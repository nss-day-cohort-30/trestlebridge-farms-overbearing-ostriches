using System.Collections.Generic;
using Trestlebridge.Models.Plants;
namespace Trestlebridge.Interfaces
{
    public interface IPlantFacility<T>
    {
        //this facility is for all plant faclities 
        double Capacity { get; }

        //allows us to add plants 
        void AddPlantResource(T resource);
        void AddPlantResource(List<T> resources);


    }
}