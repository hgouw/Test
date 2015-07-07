using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        class Pet
        {
            public virtual void Speak()
            {
                Console.WriteLine("Not Implemented");
            }
        }
        class Cat : Pet
        {
            public override void Speak()
            {
                Console.WriteLine("Meow");
            }
        }
        class Dog : Pet
        {
            public new void Speak()
            {
                Console.WriteLine("Woof");
            }
        }
        class Bird : Pet
        {
            public void Speak()
            {
                Console.WriteLine("Tweet");
            }
        }
        static void Main()
        {
            List<Pet> pets = new List<Pet>();
            pets.Add(new Cat());
            pets.Add(new Dog());
            pets.Add(new Bird());
            foreach (var pet in pets)
                pet.Speak();
            Console.ReadLine();
        }
    }
}