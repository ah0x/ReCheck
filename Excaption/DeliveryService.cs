using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Excaption.Program;

namespace Excaption
{
    class DeliveryService
    {
        private bool Faild = false;
        private readonly static Random random = new Random();
        public void Start(Delivery delivery)
        {
            try
            {
                Processs(delivery);
                Ship(delivery);
                Transit(delivery);
                Deliverd(delivery);
            }
            catch (AccidentException ex)
            {
                Console.WriteLine($"There was an accident at {ex.Location} preventing us from delivering your parcel: {ex.Message}");
                delivery.deliveryStatus = DeliveryStatus.UNKNOWN;
                Faild = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Deliver Fails due to: {ex.Message}");
                delivery.deliveryStatus = DeliveryStatus.UNKNOWN;
                Faild = true;
            }
            finally
            {
                if(Faild==true)
                {
                    Console.WriteLine("call the support plaese");
                }
                else
                {
                    Console.WriteLine("We are happy to tell you that your order is ready to take");
                }
            }
        }

        private void Processs(Delivery delivery)
        {
            FakeIt("Processing");
            if(random.Next(1,5)==1)
            {
                throw new InvalidOperationException("Unable to process the item");
            }
            delivery.deliveryStatus = DeliveryStatus.PROCESSED;
        }

        private void Ship(Delivery delivery)
        {
            FakeIt("Shiping");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("Parcel is damaged during loading process");
            }
            delivery.deliveryStatus = DeliveryStatus.SHIPPED;
        }

        private void Transit(Delivery delivery)
        {
            FakeIt("On Its Way");
            if (random.Next(1, 2) == 1)
            {
                throw new AccidentException("IRAQ - BAGHDAD","Accident !!!");
            }
            delivery.deliveryStatus = DeliveryStatus.INTRANSIT;
        }

        private void Deliverd(Delivery delivery)
        {
            FakeIt("Delivering");
            delivery.deliveryStatus = DeliveryStatus.DELIVERD;
        }

        private void FakeIt(string title)
        {
            Console.Write(title);
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            Console.WriteLine(".");
        }
    }
}
