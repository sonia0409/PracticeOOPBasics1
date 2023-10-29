using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Camry";
            string color = "Grey";
            
            MyCar car = new MyCar(name, color); // car properties can be updated by passing the arguments to the constructor
            car.Number = 12133; // or by directly setting the properties

            Console.WriteLine($"I have {car.Name} of {car.Color} color and car number plate is {car.Number}");
            Hyundai hyundai = new Hyundai(name, color);


            //interface - provides losse coupling
            Console.WriteLine("---------------Interface Class---------------");

            BaseGeometry geometries = new BaseGeometry();
            geometries.CalculateArea(100, 200);
            geometries.GetShape("rectangle");

            IBaseGeometry square = new BaseGeometry();
            square.CalculateArea(2, 2);
            //square.GetShape("square");  // error method is not defined in teh IBaseDocument class


            //Inheritance Animal : Dog
            Console.WriteLine("---------------Inheritance---------------");
            //object of derived class
            Dog labrador = new Dog();

            //access method field and method of base class
            labrador.name = "Reio";
            labrador.display();

            //access method from the derived (dog) class
            labrador.getName();
            //acccess protected method 
            //labrador.eat(); //error cannot access the method
            labrador.DisplayEat(); //error cannot access the method

            labrador.sound();

            //Abstract Class
            Console.WriteLine("---------------Abstract Class---------------");
            //LanguageAbs obj = new LanguageAbs(); //error cannot create an instance of the abstract type or interface
            deriveAbs abstractClass = new deriveAbs();
            abstractClass.displayAbstarct("abstract method overriden from an abstract class....");
            abstractClass.displayNonAbstract();

            DogAbs dog = new DogAbs();
            dog.makeSound();
            dog.Name = "Kyzo";


            //partial class

   //partial class and method
            Record myRecord = new Record(10, 15);
            myRecord.PrintRecord();

            //sealed class




            Console.ReadLine();

        }
    }
}
