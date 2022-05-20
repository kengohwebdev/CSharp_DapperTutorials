using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Persons
{
     class Department : Instructor
    {

        enum _Courses
        {
            Math,
            Biology,
            Science,
            English
        }

        private Boolean dean;
        private int startDate;
        private int endDate;

        public Department(Boolean dean, int startDate, int endDate)
        { 
           this.dean = dean;
           this.startDate = startDate;
           this.endDate = endDate;
        }

     


    }
}
