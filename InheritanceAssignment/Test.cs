using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Test : Sports
    {
        int[] marks = new int[] { 20, 25, 15, 13, 10 };
        protected int total;

        public void CalculateMarke()
        {
            total = marks.ToList().Sum();
        }

        public void DisplayMarks()
        {
            base.GetDetails();
            base.ShowDetails();
            Console.WriteLine($"Marks are : {total}");
        }
        




    }
}
