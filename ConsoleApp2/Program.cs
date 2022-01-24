using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            arr[0] = 100;
            string str = "hello";
            var c = str[0];


            //var ip = new Ip(128,112,68,0);

            var ip = new Ip("128.168.0.1");

            var firstSegment = ip[0];

            Console.WriteLine($"IP ADDRESS: {ip.Address}");
            Console.WriteLine($"First Segment: {firstSegment}");
            Console.ReadKey();
        }
    }

    public class Ip
    {
        private int[] segments =new int[4];

        public int this[int index]
        {
            get
            {
                return segments[index];
            }

            set
            {
                segments[index] = value;
            }
        }

        public Ip(string IPAddress)
        {
            var segs = IPAddress.Split('.');

            for (int i = 0; i < segs.Length; i++)
            {
                segments[i] = Convert.ToInt32(segs[i]);
            }
        }

        public Ip( int segment1 , int segment2 , int segment3 , int segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;
        }

        public string Address => string.Join(".", segments);
    }
}
