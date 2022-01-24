using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar = new Dollar(1.009m);
            dollar.setAmount(0m);
            Console.WriteLine(dollar.Amount);
            Console.WriteLine(dollar.isZero);
            Console.ReadKey();
        }
    }


    public class Dollar
    {
        private decimal _amount;

        public decimal Amount
        {
            get
            {
                return this._amount;
            }

            private set
            {
                this._amount = proccessValue(value);
            }
        }

        public void setAmount(decimal value)
        {
            Amount = value;
        }

        public Dollar(decimal amount)
        {
            this._amount = proccessValue(amount);
        }

        public decimal proccessValue(decimal value) => value <= 0 ? 0 : Math.Round(value, 2);

        public bool isZero => _amount == 0;
    }
}
