using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    internal class MyCar
    {
        //private field is accessible within the class only
        //if the access modifier is not defined; by default it would be default
        private string color;  //field
        private string name; // field

        private string model = "Toyota"; //field
        private int number;

        //constructor

        public MyCar(string color, string name)
        {
            Name = name;
            Color = color;
            Console.WriteLine($"Hey! Constructor MyCar Called....And car model is {model}");
            
        }

        //method with protected access modifier
        protected string GetCarMode()
        {
            string carModel = $"my car model is {model}";

            return carModel;
        }


        //properties
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Model
        {
            
            get { return model; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
