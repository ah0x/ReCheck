using Excaption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excaption
{
    partial class Program
    {
        static void Main(string[] args)
        {
            {
                //this will make exception unhandled that mean unreconized error not have the handleing
                //Devide();
                /*
                  try
                {
                    Devide();
                } // the code that will make the exception
                catch (System.Exception ex)
                {
                    // here is the place to handle the error
                    Console.WriteLine(ex.Message);
                }
                 */
            }

            var delivery = new Delivery { Id = 0, CustmerName = "Haa", Adrress = "USA" };
            Console.WriteLine(delivery);
            var service = new DeliveryService();
            service.Start(delivery);

            Console.ReadKey();
        }

        static int Devide()
        {
            int x = 2;
            int y = 0;
            return x / y;
        }
    }

    
}
