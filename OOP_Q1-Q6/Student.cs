using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Persons
{
    public class Student : Person
    {
        private string courses;
        private double gpa;
        private char grade;
        public Student()
        {

        }
        public Student(int age, decimal salary, String address,
                           String courses, double gpa, char grade)
         : base(age, salary, address)
        {
            this.courses = courses;
            this.gpa = gpa;
            this.grade = grade;
        }

        public String getCourse()
        {
            return courses;
        }
        public double getGPA()
        {
            return getGPA();
        }

        public char getGrade()
        {
            return grade;
        }
        public override void Classes()
        {
            Console.WriteLine("student class");
        }

        
    }
}
