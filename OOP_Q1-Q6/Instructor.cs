using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Persons
{
     public class Instructor : Person
    {
        private string department;
        private string joinDate;
        private int bonus;

        public Instructor()
        {

        }
        public Instructor(int age, decimal salary, String address,
                           String department, int bonus, string joinDate)
         : base (age, salary, address)
        {
            this.department = department;
            this.joinDate = joinDate;
            this.bonus = bonus;
        }

        public String getDepartment()
        {
            return department;
        }

        public void setDepartment(String department)
        {
            this.department=department;
        }
        public int getBonus()
        {
            return bonus;
        }
        public string getJoinDate()
        {
            return joinDate;
        }

        public void setJoinDate(int year, int month, int date)
        {
            DateTime dt = new DateTime(year, month, date);
            this.joinDate = dt.ToString();
        }

        public override void Classes()
        {
            Console.WriteLine("instructor class");
        }
    }
}
