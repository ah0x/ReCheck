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

        protected Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            this.wage = wage;
        }

        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal wage { get; set; }

        protected virtual decimal Calculate() => CalculateBaseSalary() + CalculateOverTime();

        private decimal CalculateBaseSalary() => LoggedHours * wage;

        private decimal CalculateOverTime() => ((LoggedHours - MinmumLoggedHours) > 0 ? LoggedHours - MinmumLoggedHours : 0) * wage * OverTimeRate;

        public override string ToString()
        {
            var type = GetType().ToString().Replace("Inheritance.", "");
            return $"{type}" +
                   $"\nId: {Id}" +
                   $"\nName: {Name}" +
                   $"\nLogged Hours: {LoggedHours}" +
                   $"\nwage: {wage}" +
                   $"\nBase Salary: {Math.Round(CalculateBaseSalary(),2):N0}" +
                   $"\nOver Time: {Math.Round(CalculateOverTime(), 2):N0}";
        }
    }
}
