using System;

namespace Inheritance
{
    class Manager :Employee
    {
        private const decimal AllownceRate = 0.05m;

        public Manager(int id, string name, decimal loggedHours, decimal wage):base(id,name,loggedHours,wage)
        {

        }

        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateAllownce();
        }

        private decimal CalculateAllownce()
        {
            return base.Calculate() * AllownceRate;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nAllownce: ${Math.Round(CalculateAllownce(), 2):N0}" +
                $"\nNet Salary: ${Math.Round(this.Calculate(), 2):N0}";
        }
    }
}
