using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP;
using OOP_Persons;



namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            Instructor i = new Instructor();
            

            String dep = "Engineering";


          
            //upcasting
            Person sp = new Student();
            
            //downcasting
            Student ns = Student(sp);
            
            sp.Classes();
            ns.Classes();
            
            Person p1;
            p1 = new Student();
            p1.age = 18;
            Console.WriteLine(p1.age);


           
            Student s1 = new Student();
            s1.age = 21;
           
          //Calculate age
            Person p2 = s1;
            Console.WriteLine(p2.age);



            Instructor i1 = new Instructor();
           
            i1.setJoinDate(2020, 4, 20);
            Console.WriteLine(i.getJoinDate());
            
            i1.setDepartment(dep);
            
            i1.getDepartment();
            
            
         //Boolean set instructor to head of department
            i1.isHead();

        

            //Testing overriding classes
            p2.Classes();
            Person p3 = i1;
            p3.Classes();

            String newAddress = "Mars";
            char grade = 'A';

            Student s3 = new Student(18, 0, newAddress, 4, 4.0, grade);
            Person p4 = new Student(19, 0, newAddress, 4, 0, grade);
            
            
            //Calculate GPA with abstract and encapsulation 
            //s3.AddCourse();
             s3.getGPA();


            string jDate = i1.getJoinDate();
            Person p5 = new Instructor(18, 3500, newAddress, dep, 5000, jDate);
            
            //Get Salary and address
            Console.WriteLine(p5.salary);
            Console.WriteLine(i1.salary);
            
            //Calculate Bonus
            //i1.CalculateBonus();
            i1.getBonus();
            
            
            //for loop to get courses from enum




        }



    }
}
