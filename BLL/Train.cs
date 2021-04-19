using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logic
{
    public class Train
    {
        public List<Wagon> Wagons { get; }
        public List<Animal> Animals { get; }
        public Train(int[] aAnimals) 
        {
            Animals = new List<Animal>();
            Wagons = new List<Wagon>();
            MakeAnimals(aAnimals);
            SortAnimals();
            Console.WriteLine(aAnimals);

        }
        void SortAnimals() 
        {

            Console.WriteLine(Animals);
            List<int> somethings = new List<int>();
            List<Animal> wagonAnimals = new List<Animal>();
            //AddWagon();
            Console.WriteLine(Animals);
            foreach (Animal animal in Animals)
            {
                Console.WriteLine(animal);

                if (animal.Type == Type.Carnivore && animal.Size == Size.Large)
                {
                    
                    
                    wagonAnimals.Add(animal);

                    AddWagon(wagonAnimals, true);
                    Console.WriteLine(animal);
                    somethings.Add((int)animal.Size);
                    Console.WriteLine(somethings);
                    wagonAnimals = new List<Animal>();
                }Console.WriteLine("asdad");
                if (animal.Type == Type.Carnivore && animal.Size != Size.Large)
                {
                    wagonAnimals.Add(animal);
                    AddWagon(wagonAnimals, false);
                    wagonAnimals = new List<Animal>();
                }
                if (animal.Type == Type.Herbivore)
                {
                    bool sorted = false;
                    foreach (var wagon in Wagons)
                    {

                        if (!wagon.IsFull && !sorted)
                        {

                            int AvailableSpace = wagon.GetAvailableSpace();
                            Console.WriteLine(AvailableSpace);
                            if (AvailableSpace >= (int)animal.Size)
                            {
                                Console.WriteLine("space available");
                                if (wagon.ContainsCarnivore() < (int)animal.Size)
                                {
                                    Console.WriteLine("no bigger carnivore");
                                    wagon.Animals.Add(animal);
                                    sorted = true;
                                }
                            }

                        }
                        if (wagon.GetAvailableSpace() == 0)
                        {
                            Console.WriteLine("no more space");
                            wagon.IsFull = true;
                        }
                        if (wagon.GetAvailableSpace() <= 3 && wagon.ContainsCarnivore() == 3)
                        {
                            Console.WriteLine("no more space because of carnivore");
                            wagon.IsFull = true;
                        }
                    }
                    if (!sorted)
                    {
                        Console.WriteLine("add herbivore to new wagon");
                        wagonAnimals.Add(animal);
                        AddWagon(wagonAnimals, false);
                        wagonAnimals = new List<Animal>();
                    }
                    for (int i = Wagons.Count - 1; i >= 0; i--)
                    {
                        if (Wagons[i].Animals == null)
                        {
                            Wagons.RemoveAt(i);
                        }
                    }
                }
                Console.WriteLine(Wagons);
            }
            Console.WriteLine(somethings);
            Console.WriteLine(Wagons);
        }
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
        void AddWagon()
        {
            Wagon aWagon = new Wagon(false);
            Wagons.Add(aWagon);
        }
        void AddWagon(List<Animal> aAnimals)
        {
            Wagon aWagon = new Wagon(aAnimals);
            Wagons.Add(aWagon);
        }
        void AddWagon(List<Animal> aAnimals, bool aIsFull)
        {
            Wagon aWagon = new Wagon(aAnimals, aIsFull);
            Wagons.Add(aWagon);
        }
        void DisplayWagons() 
        {

        }

    }
}
