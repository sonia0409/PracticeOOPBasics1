using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    internal class Dog:BaseAnimal
    {

        public void getName()
        {
            Console.WriteLine($"My name is {name}"); //this name variable is derived from animal base class
        }
        //overriding method from base class
        public override void sound()
        {
            Console.WriteLine("Dog barks...."); // doesnot overwrite the base method.
            base.sound();//access the base method 

        }

    }
}
