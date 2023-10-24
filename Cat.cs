using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    internal class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public float Height { get; set; }
        public short Age { get; set; }
        public void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }
        public string Cry()
        {
            return "Meow!";
        }
        public Cat(string name, string colour, float height, short age)
        {
            Name = name;
            Colour = colour;
            Height = height;
            Age = age;
        }
    }
}
