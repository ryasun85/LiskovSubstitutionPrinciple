using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public class CEO : BaseEmployee, IManager
    {    
        public override void CalculateHourlyRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank ;
        }
       
        public void GeneratePerformanceReview()
        {   //Simulating reviewing report 
            Console.WriteLine("Reviewing a direct report.");
        }

        public void FireSomeone() 
        {
            Console.WriteLine("You're Fired!");
        }

    }
}
