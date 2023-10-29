using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    //abstract method - cannot be instansiated as an object
    abstract class LanguageAbs
    {
        //abstract method
        public abstract void displayAbstarct(string text);


        //non-abstract method
        public void displayNonAbstract()
        {
            Console.WriteLine("Hello I am non-abstract method!!");
        }
    }
}
