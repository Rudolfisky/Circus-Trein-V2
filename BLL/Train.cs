using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logic
{
    public class Train
    {
        private List<Wagon> Wagons { get; set; } = new List<Wagon>();
        public Train() { }
        public Train(List<Wagon> wagons)
        {
            Wagons = wagons;
        }
        public IEnumerable<Animal> GetAllAnimals() 
        {
            List<Animal> animals = new List<Animal>();
            foreach (var wagon in Wagons)
            {
                foreach (var animal in wagon.GetAnimals())
                {
                    animals.Add(animal);
                }
            }
            return animals;
        }
        public IEnumerable<Wagon> GetAllWagons()
        {
            return Wagons;
        }
        public void addToNewWagon(Animal animal) 
        {
            //List<Animal> newAnimalList = new List<Animal>();
            //newAnimalList.Add(animal);
            Wagon newWagon = new Wagon();
            newWagon.AddAnimal(animal);
            Wagons.Add(newWagon);
            Console.WriteLine(Wagons);
        }

    }
}
