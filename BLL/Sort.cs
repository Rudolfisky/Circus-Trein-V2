using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Sort
    {
        private Train train { get; set; }
        private List<Animal> Animals { get; set; }

        private List<Animal> wagonAnimals = new List<Animal>();
        public Sort() 
        {
            train = new Train();
            Animals = new List<Animal>();
            List<Animal> wagonAnimals = new ();
        }
        public Train Start(int[] aAnimals) 
        { 
            MakeAnimals(aAnimals);
            SortAnimals();
            return train;
        }
        void SortAnimals()
        {           
            foreach (Animal animal in Animals)
            {
                if (animal.Type == Type.Carnivore)
                {
                    AnimalIsCarnivore(animal);
                }

                if (animal.Type == Type.Herbivore)
                {
                    AnimalIsHerbivore(animal);                   
                }
            }
        }
        void AnimalIsCarnivore(Animal unSortedAnimal) 
        {
            train.addToNewWagon(unSortedAnimal);
        }
        void AnimalIsHerbivore(Animal animal) 
        {
            // bool used for keeping track of the sort state of the curent animal
            bool sorted = false;
            foreach (var wagon in train.GetAllWagons())
            {
                //check if the animal has been sorted into a wagon
                if (!sorted)
                {
                    if (wagon.AddAnimal(animal)) sorted = true;
                }

            }
            //check if animal has been sorted to a wagon, if not, add it to a new one
            if (!sorted) train.addToNewWagon(animal);
        }
        // convert array with numbers into Animals
        void MakeAnimals(int[] aAnimals)
        {
            for (int i = 0; i < aAnimals[0];)
            {
                AddAnimal(Type.Carnivore, Size.Small);
                i++;
            }
            for (int i = 0; i < aAnimals[1];)
            {
                AddAnimal(Type.Carnivore, Size.Medium);
                i++;
            }
            for (int i = 0; i < aAnimals[2];)
            {
                AddAnimal(Type.Carnivore, Size.Large);
                i++;
            }
            for (int i = 0; i < aAnimals[3];)
            {
                AddAnimal(Type.Herbivore, Size.Small);
                i++;
            }
            for (int i = 0; i < aAnimals[4];)
            {
                AddAnimal(Type.Herbivore, Size.Medium);
                i++;
            }
            for (int i = 0; i < aAnimals[5];)
            {
                AddAnimal(Type.Herbivore, Size.Large);
                i++;
            }
        }
        void AddAnimal(Type aType, Size aSize)
        {
            Animal aAnimal = new Animal(aType, aSize);
            Animals.Add(aAnimal);
        }
    }
}
