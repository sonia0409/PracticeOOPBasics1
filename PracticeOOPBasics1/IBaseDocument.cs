using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    //by convention interface class starts with "I".
    //Unlike abstract class all the members (method or properties) are abstract 
    //good to instanciate the methods here, not properties
    interface IBaseDocument
    {
       
        //no access modifier used within the class
        //all members are public by default
        //just instantiate the method here, cannot define
        void CalculateArea(int l, int b);


    }
}
