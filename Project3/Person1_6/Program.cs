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
            Person p1;
            p1 = new Student();
            p1.age = 18;
            Console.WriteLine(p1.age);


            //downcasting
            Student s1 = new Student();
            s1.age = 21;
          
            Person p2 = s1;
            Console.WriteLine(p2.age);



            Instructor i1 = new Instructor();
           
            i1.setJoinDate(2020, 4, 20);
            Console.WriteLine(i.getJoinDate());
            
            i1.setDepartment(dep);
            
            i1.getDepartment();
         
            i1.isHead();

        

            //Testing overriding classes
            p2.Classes();
            Person p3 = i1;
            p3.Classes();

            String newAddress = "Mars";
            char grade = 'A';

            Student s3 = new Student(18, 0, newAddress, 4, 4.0, grade);
            Person p4 = new Student(19, 0, newAddress, 4, 0, grade);


            string jDate = i1.getJoinDate();
            Person p5 = new Instructor(18, 3500, newAddress, dep, 0, jDate);
            
            Console.WriteLine(p5.salary);
            Console.WriteLine(i1.salary);

            i1.getBonus();




        }



    }
}