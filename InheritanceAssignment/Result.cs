using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Result : Test
    {
        int totalMarks;
        public void CalculateTotalScore()
        {
            totalMarks = total + score;
        }

        public void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Final Score is " + totalMarks);

        }

    }
}
