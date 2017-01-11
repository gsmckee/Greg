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
        // in this version of the code the attributes of this class have been changed from public to private.
        // This is restricting the access of the attributes to within the class
        string m_FName = "Mad Max";
        string m_LName = "A Million";
        int m_age = 35;
        string m_HColor = "Brown";
        // The next method is referred to as a setter, because its role is to set a member variable. 
        public void SetFName(string userFirstName)
        {
            // ambiguity with variables too close in reference; ie. "m_FName= firstName;"
            // 1) copying the input of the method to itself
            // 2) copying the member variable to itself
            // 3) copying the member vsariable to the input
            // 4) copying the input to the member variable
            // use of below will minimize ambiguity or "this.m_FName = firstName"
            m_FName = userFirstName;
        }
        // This type of method (reading back a member variable) is called a getter.
        public string GetFName()
        {
            return m_FName;
        }
    }
}
