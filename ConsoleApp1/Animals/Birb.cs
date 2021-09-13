using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Birb : Animal
    {
        public Birb(string color, int age) : base(color, age)
        {
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void Rest()
        {
            throw new NotImplementedException();
        }
    }
}
