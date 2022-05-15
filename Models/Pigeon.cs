using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_oop_concepts.Models
{
    public class Pigeon : Bird
    {
        public Pigeon(string name, string color) : base(name, color)
        {
        }

        public void Speak()
        {
            Console.WriteLine($"Yo! I'm {Name} and I'm a {Color} pigeon.");
        }
        

        public void EatPizza()
        {
            Console.WriteLine("Delicious pizza!");
        }

        public override void speak()
        {
            throw new NotImplementedException();
        }
    }
}
