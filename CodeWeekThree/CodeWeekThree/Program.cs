using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWeekThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p.m_age = 34;
            //p.m_FName = "Mad Max";
            //p.m_LName = "A Million";
            Person p2= new Person();
            //p1.m_age = 18;
            // the line above does not work because "p1" does not match any existing object. Due to no instantiation of the object "p1" is trying to reference.
            // "p1" is referred to as a variable because a reference is a type of varable. 
            // Note: int, float, double, decimal, char and string are boths objects and references as the same time. 
            // There is no need to assign an object of an "int" or other integral variable type reference.

            // the following line is possible because SetFName is a public method
            // this works in previous programming languages such as c++
            p.SetFName(" Max");
            
            // The following line is using the property LastName, the property is nothing more than a convenient way to write a getter and/or setter 
            // and manipulating the member variable of the class as if its public (looks like we are accessing a public member variable).
            // this only exists in c#, not in previous programming languages.
            p.LastName = "McKee";
            int myInteger = 2;
            myInteger = 3;
            const int myOtherInteger = 3;
            myOtherInteger = 5;

        }
    }
}
