using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Persons
{
     public abstract class Person
    {


        public Person()
        {
           
        }
           
        public Person(int age, decimal salary, String address)
        {
        
        }

        public int age { get; set; }
        public decimal salary { get; set; }
        public String address { get; set; } 
       

        public abstract void Classes();
    

    }
}
