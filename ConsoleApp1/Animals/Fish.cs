using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fish : Animal
    {
        public Fish(string color, int age) : base(color, age)
        {
            Console.WriteLine("Fish Created");
        }

        public void Swim()
        {
            Console.WriteLine("Fish is swimming! Blub blub.");
        }

        public override void Rest()
        {
            Console.WriteLine("Fish is resting");
        }

        public virtual void SiftWater()
        {
            Console.WriteLine("AHHHHH OXYGEN!");
        }

        public override void Move()
        {
            Console.WriteLine("Fish is swiming!");
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
