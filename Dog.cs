using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Part2
{
    internal class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public float Height { get; set; }
        public short Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }

        public string Cry()
        {
            return "Woof!";
        }

        public Dog(string name, string colour, float height, short age) 
        {
            Name = name; 
            Colour = colour; 
            Height = height; 
            Age = age;
        }
    }
}
