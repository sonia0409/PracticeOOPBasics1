using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    internal class BaseGeometry : IBaseGeometry, IGeometry
    {
        //Implementing Multiple Interfaces, multiple interfaces are possible however multiple inheritanec is not possible in c#
        string _shape;
        public string Shape
        {
            get { return _shape; }
            set { _shape = value; }
        }
        public void GetShape(string shape)
        {
            Shape = shape;
            Console.WriteLine($"geometry type is {shape}");
        }
        public void CalculateArea(int l, int b)
        {           
            int area = l * b;
            Console.WriteLine($"Area of {Shape} is equal to " + area);
        }
        
       
    }
}
