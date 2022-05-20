using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Persons
{



    public class Student : Person
    {
        private int nCourses;
        private double gpa;
        private char grade;

        public static double gradeA = 4.0;
        public static double gradeB = 3.0;
        public static double gradeC = 2.0;
        public static double gradeD = 1.0;
        public static double gradeF = 1.0;
        public Student()
        {

        }
        public Student(int age, decimal salary, String address,
                           int nCourses, double gpa, char grade)
         : base(age, salary, address)
        {
            this.nCourses = nCourses;
            this.gpa = gpa;
            this.grade = grade;
        }

        public int getNumCourses()
        {
            return nCourses;
        }
        public double getGPA()
        {
            return grade;
        }

        public char getGrade()
        {
            return grade;
        }
        public override void Classes()
        {
            Console.WriteLine("This is a student taking a class");
        }

        
    }
}
