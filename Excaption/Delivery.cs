namespace Excaption
{
    partial class Program
    {
        public class Delivery
        {
            public int Id { get; set; }

            public string CustmerName { get; set; }

            public string Adrress { get; set; }

            public DeliveryStatus deliveryStatus { get; set; }

            public override string ToString()
            {
                return $"{{\n   id:{Id},\n   Custmer Name:{CustmerName},\n   Adrress:{Adrress},\n   Status:{deliveryStatus}\n}}";
            }
        }
    }
}
