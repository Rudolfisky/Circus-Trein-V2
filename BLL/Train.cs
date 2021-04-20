using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logic
{
    public class Train
    {
        public List<Wagon> Wagons { get; set; }
        public Train(List<Wagon> wagons)
        {
            Wagons = new List<Wagon>();
            Wagons = wagons;
        }

    }
}
