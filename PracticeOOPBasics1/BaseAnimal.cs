using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    internal class BaseAnimal
    {
        public string name; //by default it is private, access modifier "public" will make it public
        public void display()
        {
            Console.WriteLine("I am an animal");
        }
        //protected members in inheritance
        protected void eat()
        {
            Console.WriteLine("I eat dog food!");

        }
        public void DisplayEat()
        {
            eat();
        }
        //method overriding 
        public virtual void sound()
        {
            Console.WriteLine("Animal makes sound!!");
        }
    }
}
