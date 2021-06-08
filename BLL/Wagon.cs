using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logic
{
    public class Wagon
    {
        private List<Animal> Animals { get; set; } = new List<Animal>();
        public List<Animal> GetAnimals() 
        {
            return Animals;
        }
        bool CanHave(Animal unSortedAnimal) 
        { 
            bool compatible = true;

            if (compatible && GetAvailableSpace() < (int)unSortedAnimal.Size)
            {
                //wagon has no space for the animal
                compatible = false;
            }

            if (compatible && !CheckAnimalCompatiblility(unSortedAnimal))
            {
                //there is a animal in this wagon that isnt compatible with the unSortedAnimal
                compatible = false;
            }

            return compatible;
        }
        bool CheckAnimalCompatiblility(Animal unSortedAnimal) 
        {
            bool compatible = true;
            foreach (var wagonAnimal in Animals)
            {
                if (!wagonAnimal.IscompatibleWith(unSortedAnimal))
                {
                    compatible = false;
                }

            }
            return compatible;
        }
        int GetAvailableSpace() 
        {
            int space = 10 - GetUsedSpace();
            return space;
        }
        int GetUsedSpace()
        {
            int space = 0;
            foreach (Animal animal in Animals)
            {
                space += (int)animal.Size;
            }
            return space;
        }
        public bool AddAnimal(Animal animal) 
        {
            if (CanHave(animal))
            {
                Animals.Add(animal);
                return true;
            }
            return false;
        }
        public override string ToString()
        {           
            return "animals: " + Animals.Count().ToString();
        }
    }
}
