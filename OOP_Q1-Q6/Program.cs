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

           Person p1;
            Instructor i = new Instructor();
            Student s = new Student();

            String dep = "Engineering";

            p1 = new Student();
            p1.Classes();
            p1 = new Instructor();
            p1.Classes();
            p1.age = 21;
            Console.WriteLine(p1.age);
            i.setJoinDate(2020, 4, 20);
            Console.WriteLine(i.getJoinDate());
            s.age = 40;
            Console.WriteLine(s.age);
            i.setDepartment(dep);
            Console.WriteLine(i.getDepartment());

            //Upcasting 
            Person p2 = new Student();
            p2.salary = 0;
            Student s3 = new Student();
            s3.age = 1000;
            Person p3 = s3;
            Console.WriteLine(p3.age);

            
                
            

        }



    }
}
