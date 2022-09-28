using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public int LayEggs { get; set; }
        public bool RegrowLimbs { get; set; }
        public bool Herbivore { get; set; }
        public string Enviroment { get; set; }

        public Reptile()
        {
        }

        public Reptile(int age, string name, int legs, bool landAnimal, int layEggs, bool regrowLimbs, bool herbivore, string enviroment)
        {
            Age = age;
            Name = name;
            Legs = legs;
            LandAnimal = landAnimal;
            LayEggs = layEggs;
            RegrowLimbs = regrowLimbs;
            Herbivore = herbivore;
            Enviroment = enviroment;
        }
    }
}
