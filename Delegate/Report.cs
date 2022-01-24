using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Report
    {

        public delegate bool illegableSales(Employee e);

        public void ProccessEmployee(Employee[] employees, string title, illegableSales IsIllegableSales)
        {
            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var e in employees)
            {
                if (IsIllegableSales(e))
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.TotalSales} ");
                }
            }

            Console.WriteLine("\n\n");
        }

        //public void ProccessEmployeeWith60000PlusSales(Employee[] employees)
        //{
        //    Console.WriteLine("Employee With $60,000 Plus Sales");
        //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        //    foreach (var e in employees)
        //    {
        //        if(e.TotalSales >= 60000m)
        //        {
        //            Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.TotalSales} ");       
        //        }
        //    }

        //    Console.WriteLine("\n\n");
        //}

        //public void ProccessEmployeeBetween30000And59999(Employee[] employees)
        //{
        //    Console.WriteLine("Employee Between $30,000 And $60,000 Plus Sales");
        //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        //    foreach (var e in employees)
        //    {
        //        if (e.TotalSales < 60000m && e.TotalSales >= 30000m)
        //        {
        //            Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.TotalSales} ");
        //        }
        //    }

        //    Console.WriteLine("\n\n");
        //}

        //public void ProccessEmployeLessThan30000(Employee[] employees)
        //{
        //    Console.WriteLine("Employee Less Than $30,000");
        //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        //    foreach (var e in employees)
        //    {
        //        if (e.TotalSales < 30000m)
        //        {
        //            Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.TotalSales} ");
        //        }
        //    }

        //    Console.WriteLine("\n\n");
        //}
    }
}
