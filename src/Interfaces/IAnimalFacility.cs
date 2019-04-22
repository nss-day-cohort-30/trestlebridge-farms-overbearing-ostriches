using System.Collections.Generic;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Interfaces
{
    public interface IAnimalFacility<T>
    {
        double Capacity { get; }

        void AddAnimalResource(T resource);
        void AddAnimalResource(List<T> resources);
    }
}