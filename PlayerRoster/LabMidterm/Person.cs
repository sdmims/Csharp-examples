using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMidterm
{
    class Person
    {
        //instance variable
        public String name;

        //base constructor
        public Person(String name)
        {
            this.name = name;
        }
       //getter and setter  
       public String Name 
       {
        get
            {
                return name;
            }
        set
            {
                name =value;
            }
        }
    }
}
