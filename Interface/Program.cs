using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                /*
                Vehicle v1 = new Honda("Honda", "Civic", 2021);
                Honda v2 = new Honda("Honda", "Accord", 2021);
                ILoader v3 = new Caterpiller("Honda", "Civic", 2021);
                v3.UnLoad();
                */
            }

            Cashier c = new Cashier(new Cash());

            c.Checkout(2896);

            Console.ReadKey();
        }
    }
    /*
    abstract class Vehicle //abstract type
    {
        protected string Brand;
        protected string Model;
        protected int year;

        public Vehicle(string brand, string model, int year)
        {
            this.Brand = brand;
            this.Model = model;
            this.year = year;
        }
    }

    interface IDrivable
    {
        void Move();
        void Stop();
    }

    class Honda: Vehicle,IDrivable // concrete type
    {
        public Honda(string brand, string model, int year):base(brand,model,year)
        {

        }

        public void Move()
        {
            Console.WriteLine("Moving");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping");
        }
    }

    interface ILoader
    {
        void Load();
        void UnLoad();
    }

    class Caterpiller:Vehicle,ILoader,IDrivable
    {
        public Caterpiller(string brand, string model, int year) : base(brand, model, year)
        {

        }

        public void Load()
        {
            Console.WriteLine("Loading");
        }

        public void UnLoad()
        {
            Console.WriteLine("UnLoading");
        }

        public void Move()
        {
            Console.WriteLine("Moving");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping");
        }
    }
    */

    class Cashier
    {
        private Cash _cash;

        public Cashier(Cash cash)
        {
            _cash = cash;
        }

        public void Checkout(decimal amount)
        {
            _cash.Pay(amount);
        }
    }

    class Cash
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Cash Payment ${Math.Round(amount,2):N0}");
        }
    }
}
