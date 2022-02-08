using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee
    {
        public const int MinmumLoggedHours = 176;
        public const decimal OverTimeRate = 1.25m;

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal LoggedHours { get; set; }
        public decimal wage { get; set; }

        public virtual decimal Calculate() => CalculateBaseSalary() + CalculateOverTime();

        private decimal CalculateBaseSalary() => LoggedHours * wage;

        private decimal CalculateOverTime() => ((LoggedHours - MinmumLoggedHours) > 0 ? LoggedHours - MinmumLoggedHours : 0) * wage * OverTimeRate;

        public override string ToString()
        {
            return $"\nId: {Id}" +
                   $"\nName: {Name}" +
                   $"\nLogged Hours: {LoggedHours}" +
                   $"\nwage: {wage}" +
                   $"\nBase Salary: {Math.Round(CalculateBaseSalary(),2):N0}" +
                   $"\nOver Time: {Math.Round(CalculateOverTime(), 2):N0}";
        }
    }
}
