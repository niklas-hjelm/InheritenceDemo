using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cricket : Animal
    {
        public Cricket(string color, int age) : base(color, age)
        {
            Console.WriteLine("Cricket created");
        }

        public void SoundAnnoying()
        {
            Console.WriteLine("BRRRRIIIIIIISCHP BRRRIIIISCHP!");
        }

        public override void Rest()
        {
            Console.WriteLine("Cricket is resting");
        }

        public override void Move()
        {
            Console.WriteLine("Cricket is jumping!");
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
