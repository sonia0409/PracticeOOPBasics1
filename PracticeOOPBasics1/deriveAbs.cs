using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    internal class deriveAbs: LanguageAbs
    {
        //provide implementation of the abstract method
        public override void displayAbstarct(string text) //use override keyword to avoid error
        {
            Console.WriteLine(text);
        }
    }
}
