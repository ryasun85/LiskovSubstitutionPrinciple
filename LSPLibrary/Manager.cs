using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public class Manager : Employee, IManager
    {
        public override void CalculateHourlyRate(int rank)
        { 
            decimal baseAmount = 19.75M;
            Salary = baseAmount + (rank * 4);
        }
        
        public void GeneratePerformanceReview()
        {   //Simulating reviewing report 
            Console.WriteLine("Reviewing a direct report.");
        }

    }
}
