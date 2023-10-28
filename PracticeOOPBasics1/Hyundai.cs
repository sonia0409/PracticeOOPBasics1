using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    internal class Hyundai : MyCar
    {
        public Hyundai(string color, string name) : base(color, name)
        {
            Console.WriteLine($"I am from hyundai class, inheriting the color, name properties from my base class 'MyCar'");
            Console.WriteLine($"protected and private Model property from the class MyCar is {Model}");
        }
    }
}
