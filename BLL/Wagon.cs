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
    }
}
