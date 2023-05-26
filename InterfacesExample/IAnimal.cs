using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    public interface IAnimal
    {
        public int NumberOfLegs { get; set; }
        public int Age { get; set; }

        //Interfaces are completely abstract
        public void Move();
        public void MakeNoise();
    }
}
