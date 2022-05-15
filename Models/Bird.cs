using System;

namespace Introduction_oop_concepts.Models
{
    public abstract class Bird : IDance
    {
        public string Name { get;  protected set; }
        public string Color { get; protected set; }

        public Bird(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract void speak();

        public virtual void Fly()
        {
            Console.WriteLine("Hi there! I can fly.");
        }
        
        public void Spin()
        {
            Console.WriteLine($"{Name} spin!");
        }

        public void DoTheCaterpillar()
        {
            Console.WriteLine($"{Name} do the wriggly woo!");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} jump in the air!");
        }
    }
}
