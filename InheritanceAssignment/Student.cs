using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Student
    {
         int rollno;
         string name;

        public void GetDetails()
        {

            Console.WriteLine("Enter the rollno");
            rollno = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name");
            name = (Console.ReadLine());
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Name is:{name}");
            Console.WriteLine($"Roll no is:{rollno}");
        }

    }
}
