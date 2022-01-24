using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine(e1.EmployeeInsurance.CompanyName);
            Console.ReadKey();
        }
    }

    // Nested class will see sny thing pravite

    class A
    {
        private int x;

        class C
        {
            void method()
            {
                A a = new A();
                a.x = 10;
            }
        }
    }

    class B
    {

    }

    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Insurance EmployeeInsurance { get; set; }

        //public Employee()
        //{
        //    EmployeeInsurance = new Insurance { PolcyId = -1, CompanyName = "N/A" };
        //}

        public Employee() => EmployeeInsurance = new Insurance { PolcyId = -1, CompanyName = "N/A" };

        public class Insurance
        {
            public int PolcyId { get; set; }
            public string CompanyName { get; set; }
        }
    }

    //class Insurance
    //{
    //    public int PolcyId { get; set; }

    //    public string  CompanyName { get; set; }
    //}

    class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
