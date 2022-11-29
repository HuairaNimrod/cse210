using System;
using System.Collections.Generic;

namespace Interface 
{
    class Interface
    {
        static void Main()
        {
            // create a list of IAnimal
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Dog());
            animals.Add(new Cat());

            // iterate over each IAnimal and use the common method
            foreach(IAnimal animal in animals)
            {
                string sound = animal.Onomatopoeia();
                Console.WriteLine(sound);
            }
        }
    }
}