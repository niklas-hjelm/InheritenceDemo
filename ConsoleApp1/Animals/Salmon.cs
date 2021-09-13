using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Salmon : Fish
    {
        public Salmon(string color, int age) : base(color, age)
        {
            Console.WriteLine("Salmon Created");
        }

        public override void Rest()
        {
            base.Rest();
        }

        public override void SiftWater()
        {
            base.SiftWater();
        }
    }
}
