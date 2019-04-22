using System.Collections.Generic;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Interfaces
{
    public interface IAnimalFacility<T>
    {
        double Capacity { get; }

<<<<<<< HEAD
        void AddAnimalResource (T resource);
        void AddAnimalResource (List<T> resources);
=======
        void AddAnimalResource(T resource);
        void AddAnimalResource(List<T> resources);
>>>>>>> master
    }
}