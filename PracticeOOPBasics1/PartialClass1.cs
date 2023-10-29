using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    internal class PartialClass1
    {
    }
    public partial class Record
    {
        private int h;
        private int w;
        public Record(int h, int w)
        {
            this.h = h;
            this.w = w;
        }
    }
    public partial class Car
    {
        //Note: the partial method below do not have virtaul keyword
        partial void InitializeCar();
        public void BuildRim()
        {

        }
        public void BuildWheels()
        {

        }
    }
}
