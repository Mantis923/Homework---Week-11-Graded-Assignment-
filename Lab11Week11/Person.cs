using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11Week11
{
    class Person
    {
        private string name;
        
        public Person() { name = ""; }
        public Person(string theName)
        {
           name = theName;
        }

        public Person(Person theobj)
        {
            name = theobj.name;
        }

        public string GetName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public override string ToString() { return name; }

        public override bool Equals(Object obj ) 
        {
            if (obj is Person)
            {
                Person newPerson = (Person)obj;  //we are type casting obj from an object to a person so we can access it's name

                return name == newPerson.name; // we are comparing name with newPerson.name  and returning the result
            }
            else
                return false;
        }

    }
}
