using System;

namespace Inheritance
{
    class Developer : Employee
    {
        protected bool TaskCompleted { get; set; }
        private const decimal Commission = 0.03m;

        public Developer(int id, string name, decimal loggedHours, decimal wage, bool TaskCompleted) : base(id, name, loggedHours, wage)
        {
            this.TaskCompleted = TaskCompleted;
        }

        private decimal CalculateBounce()
        {
            if (TaskCompleted)
                return base.Calculate() * Commission;
            else
                return 0;
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBounce();
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nTaskCompleted: ${(TaskCompleted ? "Yes" : "No")}" +
                $"\nCommission: ${Math.Round(Commission, 2):N0}" +
                $"\nNet Salary: ${Math.Round(this.Calculate(), 2):N0}";
        }
    }
}
