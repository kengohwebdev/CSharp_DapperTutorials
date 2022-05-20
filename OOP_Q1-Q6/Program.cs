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
            
                
            

        }



    }
}