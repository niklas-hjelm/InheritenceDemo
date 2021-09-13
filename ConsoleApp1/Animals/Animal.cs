using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Animal
    {
        private string _color;
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Animal(string color, int age)
        {
            Color = color;
            Age = age;
            Console.WriteLine("Animal Created");
        }

        public abstract void Eat(string food);

        public abstract void Rest();

        public abstract void Move();
    }
}
