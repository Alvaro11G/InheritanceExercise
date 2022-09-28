using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird ShoeBill = new Bird()
            {
                Name = "ShoeBill",
                Age = 36,
                Legs = 2,
                LandAnimal = true,
                CanFly = true,
                WingSpan = 8,
                Feathers = "gray",
                IsSmart = true
            };
            Console.WriteLine($"{ShoeBill.Name} birds live up to {ShoeBill.Age} years old. They have {ShoeBill.Legs} legs and is {ShoeBill.LandAnimal} they are land animals.");
            Console.WriteLine($"They have a {ShoeBill.WingSpan} foot wingspan and its {ShoeBill.CanFly} they can fly.");
            Console.WriteLine($"Its {ShoeBill.Feathers} feathers and beak may make it seem intimidating. Its also {ShoeBill.IsSmart} that they are smart.");
            Console.WriteLine("");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile KomodoDragon = new Reptile()
            {
                Name = "Komodo Dragon",
                Age = 30,
                Legs = 4,
                LandAnimal = true,
                LayEggs = 30,
                RegrowLimbs = false,
                Herbivore = false,
                Enviroment = "tropical savanna forests"
            };
            Console.WriteLine($"The {KomodoDragon.Name} can live up to {KomodoDragon.Age} years and is {KomodoDragon.LandAnimal} they are a land animals in {KomodoDragon.Enviroment}.");
            Console.WriteLine($"They have {KomodoDragon.Legs} legs, lay up to {KomodoDragon.LayEggs} eggs, and is {KomodoDragon.Herbivore} they are herbivores.");
            Console.WriteLine($"Its also {KomodoDragon.RegrowLimbs} that they regrow limbs.");
        }
    }
}
