using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    abstract class AnimalAbs
    {
        protected string name;

        public AnimalAbs()
        {
            Name = name;
         Console.WriteLine($"Animal abstrct Constructor");
        }

        public abstract string Name
        {
            ////error cannot declare body since it is marked abstract
            //get { return name; } 
            //set { name = value; }

            //initiate the method
            get;
            set;
            
        }
        //abstract method 
        public abstract void makeSound();

    }
}
