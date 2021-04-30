using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logic
{
    public class Animal
    {
        public Type Type { get; set; }
        public Size Size { get; set; }
        public Animal(Type aType, Size aSize) 
        {
            Type = aType;
            Size = aSize;
        }

        public bool IscompatibleWith(Animal unSortedAnimal) 
        {
            bool compatible = true;

            if (Type == Type.Carnivore && unSortedAnimal.Type == Type.Carnivore && compatible == true)
            {
                // if both This animal and unSortedAnimal are a carnivore
                compatible = false;
            }
            if (Type == Type.Carnivore && Size >= unSortedAnimal.Size && compatible == true)
            {
                // if this carnivore is bigger then unSortedAnimal herbivore
                compatible = false;
            }

            return compatible;
        }
        public override string ToString()
        {
            return Size.ToString() + "-" + Type.ToString();
        }
    }
}
