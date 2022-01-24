using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpreatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(10);
            Money m2 = new Money(20);
            Console.WriteLine($"Money1 m1: ${m1.Amount}, Money2 m2 ${m2.Amount}");

            Money m3 = m1 +  m2;
            Console.WriteLine($"Money1 + Money2: = ${m3.Amount}");
            Console.ReadKey();
        }
    }

    class Money
    {
        private decimal amount;

        public decimal Amount => amount;

        public Money(decimal value)
        {
            this.amount = Math.Round(value,2);
        }

        public static Money operator +(Money m1,Money m2)
        {
            var value = m1.amount + m2.amount;
            return new Money(value);
        }
    }
}
