using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    //sealed keyword - restrict inheriting the sealed class
    //- no derived class
    sealed class AnimalSealed
    {
    }
    public class Animal
    {
     
        public virtual void makeSound()
        {
            Console.WriteLine("Animal Sound!!");
        }
    }
}
