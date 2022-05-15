using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_oop_concepts.Models
{
    public class Penguin : Bird
    {
        public Penguin(string name, string color) : base(name, color)
        {
        }

        public void Speak()
        {
            Console.WriteLine($"Hi! I'm {Name} and I'm a {Color} penguin.");
        }
        
        public override void Fly()
        {
            Console.WriteLine($"Whoops, I can't fly. Waddle waddle.");
        }

        public override void speak()
        {
            throw new NotImplementedException();
        }
    }
}
