using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPLibrary;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manager accountingVP = new Manager();
            //IManager accountingVP = new CEO();
            IManager accountingVP = new Manager();

            accountingVP.FirstName = "Monika";
            accountingVP.LastName = "Johan";
            accountingVP.CalculateHourlyRate(4);

            IManaged emp = new Manager(); 
            //Employee emp = new Employee();
            //BaseEmployee emp = new BaseEmployee();  would work if Base class not abstract
            //Employee emp = new Manager(); will work too
            /* BaseEmployee emp = new CEO(); *///would work if no AssignManager method called

            emp.FirstName = "Clark";
            emp.LastName = "Kent";
            emp.AssignManager(accountingVP);
            emp.CalculateHourlyRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is £{emp.Salary}/hour.");
            Console.ReadLine();
        }
    }
}
