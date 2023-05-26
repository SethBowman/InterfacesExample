using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    public class Cat : IAnimal
    {
        public int NumberOfLegs { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public void MakeNoise()
        {
            Console.WriteLine("Meow!");
        }

        public void Move()
        {
            Console.WriteLine("Cat is jumping..");
        }
    }
}
