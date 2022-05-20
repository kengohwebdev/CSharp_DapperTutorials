using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Persons
{
    public class Instructor : Person
    {
        private string buildDepartment;
        private string joinDate;
        private int bonus;
        private Boolean head = false;
        private String rank;

        public Instructor()
        {

        }
        public Instructor(int age, decimal salary, String address,
                           String buildDepartment, int bonus, string joinDate)
         : base(age, salary, address)
        {
            this.buildDepartment = buildDepartment;
            this.joinDate = joinDate;
            this.bonus = bonus;
        }

        public String getDepartment()
        {
            Console.WriteLine($"This is the {buildDepartment} department");
            return buildDepartment;
        }

        public void setDepartment(String buildDepartment)
        {
            this.buildDepartment = buildDepartment;
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


        public Boolean isHead()
        {
            head = true;
            Console.WriteLine("This person is the head of department!");
            return head;
        }

        public String getRank()
        {
            return rank;
        }

        public void setRank(String rank)
        {
            this.rank = rank;
        }
        public override void Classes()
        {
            Console.WriteLine("This person is an instructor teaching a class");
        }
    }
}
