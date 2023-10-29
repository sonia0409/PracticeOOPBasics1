using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    internal class DogAbs:AnimalAbs
    {
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public DogAbs() 
        {
            
            Console.WriteLine("Dog Constructor!!");
        }
        public override void makeSound()
        {
            Console.WriteLine("Bark Bark!!");
        }

       
    }
}
