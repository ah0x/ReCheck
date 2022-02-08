using System;

namespace Inheritance
{
    class Manager :Employee
    {
        public const decimal AllownceRate = 0.05m;

        public override decimal Calculate()
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
