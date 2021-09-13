using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();

            var fish = new Fish("Yellow", 100);
            var cricket = new Cricket("Green", 50);
            var salmon = new Salmon("Pink", 150);

            animals.Add(fish);
            animals.Add(cricket);
            animals.Add(salmon);

            foreach (var animal in animals)
            {
                animal.Eat("fodder");
                animal.Rest();

                if (animal is Fish daFish)
                {
                    daFish.Swim();
                }
                else if (animal is Cricket daCricket)
                {
                    daCricket.SoundAnnoying();
                }

            }
        }
    }
}
