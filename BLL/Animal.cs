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
        public override string ToString()
        {
            return Size.ToString() + "-" + Type.ToString();
        }
    }
}
