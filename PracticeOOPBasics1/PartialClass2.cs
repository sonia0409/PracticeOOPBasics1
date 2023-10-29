using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    internal class PartialClass2
    {
    }

    public partial class Record
    {
        public void PrintRecord()
        {
            Console.WriteLine("Height:"+ h);
            Console.WriteLine("Weight:"+ w);
        }
    }
    public partial class Car
    {
        public void BuildEngine()
        {

        }
        //partial method intiated in PartialClass1 has implementation here in PartialClass2
        //Note: no override keyword is used
        partial void InitializeCar()
        {
            string str = "Car";
        }
    }
}
