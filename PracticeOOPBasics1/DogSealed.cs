using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    //cannot derive from the sealed class
    //internal class DogSealed:AnimalSealed 
    internal class DogSealed : Animal
    {
        //sealed method
        //to protect the method from overriden while multilevel inheritance
        sealed public override void makeSound()
        {
            base.makeSound();
            Console.WriteLine("Dog Sound ");
        }
       
    }
    class Puppy : DogSealed
    {
        //trying to override sealed method
        //public override void makeSound()
        //{
        //    Console.WriteLine("Puppy Sound");//cannot be overriden since it is sealed method
        //}
    }
}
