using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppc_abvanced
{
    internal class Report
    {
        public delegate bool Sales(Employee emp);
       public void salarybiggerthan30000(Employee [] emp  )
       {
            Console.WriteLine("Employee with salaries bigger than 30000");
            foreach(Employee e in emp)
            {
                if(e.salary > 30000)
                {
                    Console.WriteLine($" {e.name} {e.salary} {e.ID} {e.age} ");
                }
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
       }
        public void salarylessthan30000(Employee[] emp)
        {
            Console.WriteLine("Employee with salaries less than 30000");
            foreach (Employee e in emp)
            {
                if (e.salary < 30000)
                {
                    Console.WriteLine($" {e.name} {e.salary} {e.ID} {e.age} ");
                }
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        public void salarybetween30000and60000(Employee[] emp)
        {
            Console.WriteLine("Employee with salaries between 30000 and 60000");
            foreach (Employee e in emp)
            {
                if (e.salary >= 30000 && e.salary <= 60000)
                {
                    Console.WriteLine($" {e.name} {e.salary} {e.ID} {e.age} ");
                }
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        // no dupicate 
        public void salaries_report(Employee[] emps, string cond, Sales in_range)
        {
            Console.WriteLine(cond);
            Console.WriteLine("----------------------------------------------------");
            foreach (Employee e in emps)
            {
                if (in_range(e))
                {
                    Console.WriteLine($"{e.name} | {e.salary} | {e.ID} | {e.age} ");
                }
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
