using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("Amzon");
            stock.Price = 100;
            stock.OnPriceChanged += Stock_OnPriceChanged;

            //Console.WriteLine($"stock before changing: ${stock.Price}");
            //stock.ChangeStockPriceBy(0.05m);
            //Console.WriteLine($"stock After changing: ${stock.Price}");
            stock.ChangeStockPriceBy(0.05m);
            stock.ChangeStockPriceBy(-0.05m);
            stock.ChangeStockPriceBy(0.00m);

            Console.ReadKey();
        }

        private static void Stock_OnPriceChanged(Stock stock, decimal oldPrice)
        {
            if(stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if(stock.Price < oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine($"{stock.Name}: {stock.Price}");
        }
    } //Subscrier

    public delegate void StockPriceChangeHandler(Stock stock,decimal oldPrice);

    public class Stock
    {
        private string name;
        private decimal price;

        public event StockPriceChangeHandler OnPriceChanged;

        public string Name => this.name;

        public decimal Price
        {
            get => this.price;
            set => this.price = value;
        }

        public Stock(string stockName)
        {
            this.name = stockName;
        }

        public void ChangeStockPriceBy(decimal Percanteg)
        {
            decimal oldPrice = this.price;
            this.price += Math.Round(this.price * Percanteg, 2);

            if(OnPriceChanged != null) // check if there is any subscriber
            {
                OnPriceChanged(this,oldPrice);// share the event
            }
        }
    }//Publisher
}
