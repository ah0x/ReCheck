using System;

namespace Inheritance
{
    class Sales : Employee
    {
        protected decimal SalesVolume { get; set; }
        protected decimal Commission { get; set; }

        public Sales(int id, string name, decimal loggedHours, decimal wage, decimal SalesVolume, decimal Commission) : base(id, name, loggedHours, wage)
        {
            this.SalesVolume = SalesVolume;
            this.Commission = Commission;
        }

        private decimal CalculateBounce() => SalesVolume * Commission;

        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBounce();
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nHardShip: ${Math.Round(CalculateBounce(), 2):N0}" +
                $"\nCommission: ${Math.Round(Commission, 2):N0}%" +
                $"\nNet Salary: ${Math.Round(this.Calculate(), 2):N0}";
        }
    }
}
