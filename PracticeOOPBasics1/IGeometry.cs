using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPBasics1
{
    interface IGeometry
    {
        //if define the method it throws error, just declare/instanciate the method in the interface
        void GetShape(string shape);
        
    }
}
