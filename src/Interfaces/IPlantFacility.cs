using System.Collections.Generic;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Interfaces
{
    public interface IPlantFacility<T>
    {
        double Capacity { get; }

<<<<<<< HEAD
        void AddPlantResource (T resource);
        void AddPlantResource (List<T> resources);
=======
        void AddPlantResource(T resource);
        void AddPlantResource(List<T> resources);
>>>>>>> master
    }
}