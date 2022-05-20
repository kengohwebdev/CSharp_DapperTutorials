using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Persons
{
    public class Course 
    {

        public Course()
        {
            
        }

      public Course(String Id, String Name, String Address)
        
        {
          
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public String Address { get; set; }


        enum EnrolledStudent
        {
          Ken, 
          StacyMom,
          Chandler,
          Michael,
          Nancy
        }

    }
}
