using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_oop_concepts.Models
{
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color)
        {
            Name = name;
            Color = color;
        }

        public void Speak()
        {
            Console.WriteLine($"My name is { Name } and I am a { Color} bird.");
            Console.WriteLine($"{Name} says hello to all Vijay classmates & coaches :) ");
        }

        
    }
} 
