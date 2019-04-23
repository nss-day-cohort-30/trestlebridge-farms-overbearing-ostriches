using System.Collections.Generic;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Interfaces
{
    public interface IPlantFacility<T>
    {
        double Capacity { get; }
        void AddPlantResource(T resource);
        void AddPlantResource(List<T> resources);
    }
}