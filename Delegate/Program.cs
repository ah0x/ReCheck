using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    public delegate void rectdelagte(decimal widht, decimal hiegt);

    class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee { Id=1,Name="Ali",Gender="M",TotalSales=65000m},
                new Employee { Id=2,Name="x",Gender="F",TotalSales=50000m},
                new Employee { Id=3,Name="c",Gender="F",TotalSales=65000m},
                new Employee { Id=4,Name="v",Gender="F",TotalSales=40000m},
                new Employee { Id=5,Name="v",Gender="M",TotalSales=42000m},
                new Employee { Id=6,Name="b",Gender="M",TotalSales=30000m},
                new Employee { Id=7,Name="n",Gender="F",TotalSales=16000m},
                new Employee { Id=8,Name="m",Gender="M",TotalSales=15000m},
            };

            var report = new Report();

            //report.ProccessEmployeeWith60000PlusSales(emps);
            //report.ProccessEmployeeBetween30000And59999(emps);
            //report.ProccessEmployeLessThan30000(emps);

            //report.ProccessEmployee(emps, "Sales More than $60,000", delegate (Employee e) { return e.TotalSales > 60000m; });
            //report.ProccessEmployee(emps, "Sales Between $30,000 And $59,999", delegate (Employee e) { return e.TotalSales > 30000m && e.TotalSales < 60000m; });
            //report.ProccessEmployee(emps, "Sales Less than $30,000", delegate (Employee e) { return e.TotalSales < 30000m; });

            //report.ProccessEmployee(emps, "Sales More than $60,000", (Employee e) => e.TotalSales > 60000m);
            //report.ProccessEmployee(emps, "Sales Between $30,000 And $59,999", (Employee e) => e.TotalSales > 30000m && e.TotalSales < 60000m);
            //report.ProccessEmployee(emps, "Sales Less than $30,000", (Employee e) => e.TotalSales < 30000m);

            report.ProccessEmployee(emps, "Sales More than $60,000", e => e.TotalSales > 60000m);
            report.ProccessEmployee(emps, "Sales Between $30,000 And $59,999", e => e.TotalSales > 30000m && e.TotalSales < 60000m);
            report.ProccessEmployee(emps, "Sales Less than $30,000", e => e.TotalSales < 30000m);


            var rectangle = new Rectangle();
            rectangle.GetArea(10, 10);
            rectangle.GetPerimeter(10, 10);

            rectdelagte rect;
            rect = rectangle.GetArea;
            rect += rectangle.GetPerimeter;

            rect(10, 10);
            
            Console.ReadKey();
        }

        //static bool SalesMorethan60000(Employee e) => e.TotalSales > 60000m;

        //static bool SalesBetween30000And59999(Employee e) => e.TotalSales > 30000m && e.TotalSales < 60000m;

        //static bool SalesLessthan30000(Employee e) => e.TotalSales < 30000m;
    }

    public class Rectangle
    {
        public void GetArea(decimal widht, decimal hiegt)
        {
            var result = widht * hiegt;
            Console.WriteLine($"Area: {widht} x {hiegt} = {result}");
        }

        public void GetPerimeter(decimal widht, decimal hiegt)
        {
            var result = (widht + hiegt) * 2;
            Console.WriteLine($"Perimeter: ({widht} + {hiegt}) x2 = {result}");
        }
    }

}
