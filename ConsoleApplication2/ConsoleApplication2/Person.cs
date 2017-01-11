using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Person
    {
        // the next 3 variables are declared as master variables of the class person.
        // The master variables are also referred to as properties.
        public string m_FName;
        public string m_LName;
        public int m_age;
        protected string m_HColor = "Brown";
    }
}
