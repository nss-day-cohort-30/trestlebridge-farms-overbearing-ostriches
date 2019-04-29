using System.Collections.Generic;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Interfaces
{
    public interface IAnimalFacility<T>
    {
        // the interface given to all facilities that hold animals 
        double Capacity { get; }


        //the method allowing us to add animals to an animal facility
        void AddAnimalResource(T resource);
        void AddAnimalResource(List<T> resources);
    }
}