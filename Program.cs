using System;
using System.Collections.Generic;
using Introduction_oop_concepts.Models;

namespace Introduction_oop_concepts
{
    public class Program
    {
       public static void Main()
        {
            
            Pigeon pippa = new ("Pippa", "Grey");
            pippa.Speak();
            pippa.Fly();
            pippa.EatPizza();
            pippa.Spin();
            pippa.DoTheCaterpillar();
            pippa.Jump();

            Penguin pingu = new("Pingu", "Black & White");
            pingu.Speak();
            pingu.Fly();
            pingu.Spin();
            pingu.DoTheCaterpillar();
            pingu.Jump();


       }

       
    }
}
