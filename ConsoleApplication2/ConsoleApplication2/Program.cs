using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
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
            p.SetFName(" Max");
        }
    }
}
