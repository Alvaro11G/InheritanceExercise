using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{   //inherits from animal class
    class Bird : Animal
    {
        public bool CanFly { get; set; }
        public int WingSpan { get; set; }
        public string Feathers { get; set; }
        public bool IsSmart { get; set; }

        public Bird()
        {
        }

        public Bird(int age, string name, int legs, bool landAnimal, bool canFly, int wingSpan, string feathers, bool isSmart)
        {
            Age = age;
            Name = name;
            Legs = legs;
            LandAnimal = landAnimal;
            CanFly = canFly;
            WingSpan = wingSpan;
            Feathers = feathers;
            IsSmart = isSmart;
        }
    }
}
