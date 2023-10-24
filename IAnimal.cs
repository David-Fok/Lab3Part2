using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    internal interface IAnimal
    {
        string Name { get; set; }
        string Colour { get; set; }
        float Height { get; set; }
        short Age { get; set; }

        void Eat();
        string Cry();
    }
}
