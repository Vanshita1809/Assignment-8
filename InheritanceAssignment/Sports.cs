using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceAssignment
{
    public class Sports : Student
    {
        string sportsname;
        protected int score;

        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter the sportsname");
            sportsname = (Console.ReadLine());
            Console.WriteLine("Enter the score");
            score = int.Parse(Console.ReadLine());
        }
        public void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Sports Name is:{sportsname}");
            Console.WriteLine($"Scoreis:{score}");
        }
    }

}
