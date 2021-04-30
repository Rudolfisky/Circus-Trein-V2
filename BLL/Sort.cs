using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Sort
    {
        List<Wagon> Wagons { get; }
        List<Animal> Animals { get; }

        List<Animal> wagonAnimals = new List<Animal>();
        public Sort() 
        {
            Animals = new List<Animal>();
            Wagons = new List<Wagon>();
            List<Animal> wagonAnimals = new ();
        }
        public List<Wagon> Start(int[] aAnimals) 
        { 
            MakeAnimals(aAnimals);
            SortAnimals();
            Console.WriteLine(aAnimals);
            return Wagons;
        }
        void SortAnimals()
        {
           
            foreach (Animal animal in Animals)
            {
                // new start
                if (animal.Type == Type.Carnivore)
                {
                    AnimalIsCarnivore(animal);
                }
                // new end

                // old start
                //if (animal.Type == Type.Carnivore && animal.Size == Size.Large)
                //{
                //    wagonAnimals.Add(animal);

                //    AddWagon(wagonAnimals, true);
                //    Console.WriteLine(animal);
                //    somethings.Add((int)animal.Size);
                //    Console.WriteLine(somethings);
                //    wagonAnimals = new List<Animal>();
                //}

                //if (animal.Type == Type.Carnivore && animal.Size != Size.Large)
                //{
                //    wagonAnimals.Add(animal);
                //    AddWagon(wagonAnimals, false);
                //    wagonAnimals = new List<Animal>();
                //}
                // old end
                if (animal.Type == Type.Herbivore)
                {
                    bool sorted = false;
                    foreach (var wagon in Wagons)
                    {
                        //new start
                        if (!wagon.IsFull && !sorted)
                        {
                            if (wagon.CanHave(animal))
                            {
                                Console.WriteLine("no bigger carnivore");
                                wagon.Animals.Add(animal);
                                sorted = true;
                            }
                        }
                        //new end

                        //old start
                        //if (!wagon.IsFull && !sorted)
                        //{

                        //    int AvailableSpace = wagon.GetAvailableSpace();
                        //    Console.WriteLine(AvailableSpace);
                        //    if (AvailableSpace >= (int)animal.Size)
                        //    {
                        //        Console.WriteLine("space available");
                        //        if (wagon.ContainsCarnivore() < (int)animal.Size)
                        //        {
                        //            Console.WriteLine("no bigger carnivore");
                        //            wagon.Animals.Add(animal);
                        //            sorted = true;
                        //        }
                        //    }

                        //}
                        //new end
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
            Console.WriteLine(Wagons);
        }
        void AnimalIsCarnivore(Animal unSortedAnimal) 
        {
            if (unSortedAnimal.Type == Type.Carnivore && unSortedAnimal.Size == Size.Large)
            {
                wagonAnimals.Add(unSortedAnimal);

                AddWagon(wagonAnimals, true);
                wagonAnimals = new List<Animal>();
            }

            if (unSortedAnimal.Type == Type.Carnivore && unSortedAnimal.Size != Size.Large)
            {
                wagonAnimals.Add(unSortedAnimal);
                AddWagon(wagonAnimals, false);
                wagonAnimals = new List<Animal>();
            }
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
    }
}
