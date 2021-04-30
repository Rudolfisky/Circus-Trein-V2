using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logic
{
    public class Wagon
    {
        public List<Animal> Animals { get; set; }
        public bool IsFull { get; set; }

        public Wagon(List<Animal> aAnimalsList) 
        {
            Animals = new List<Animal>();
            Animals = aAnimalsList;
        }
        public Wagon(List<Animal> aAnimalsList, bool aIsFull)
        {
            Console.WriteLine(Animals);
            Animals = new List<Animal>();
            Animals = aAnimalsList;
            IsFull = aIsFull;
            Console.WriteLine(Animals);
        }
        public Wagon( bool aIsFull)
        {
            Animals = new List<Animal>();
            IsFull = aIsFull;
        }
        public bool CanHave(Animal unSortedAnimal) 
        { 
            bool compatible = true;
            if (IsFull)
            {
                //wagon is full
                compatible = false;
            }

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
        public int GetAvailableSpace() 
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
        public int ContainsCarnivore() 
        {
            int CC = 0;
            foreach (Animal animal in Animals)
            {
                if (animal.Type == Type.Carnivore)
                {
                    CC = (int)animal.Size;
                }
            }
            return CC;
        }
        public override string ToString()
        {           
            return "animals:" + Animals.Count().ToString() + "; isFull:" + IsFull.ToString();
        }
    }
}
