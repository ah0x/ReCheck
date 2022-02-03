using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalSize Size = new DigitalSize(60000);

            DigitalSize Size2 = Size.AddBit(8);

            Console.WriteLine(Size.Bit);
            Console.WriteLine(Size.Byte);
            Console.WriteLine(Size.KB);
            Console.WriteLine(Size.MB);
            Console.WriteLine(Size.GB);
            Console.WriteLine(Size.TB);

            Console.WriteLine("----------- This is the deferent between the refrence type and value type -------------");

            Console.WriteLine(Size2.Bit);
            Console.WriteLine(Size2.Byte);
            Console.WriteLine(Size2.KB);
            Console.WriteLine(Size2.MB);
            Console.WriteLine(Size2.GB);
            Console.WriteLine(Size2.TB);

            Console.ReadKey();
        }
    }

    struct DigitalSize
    {
        private long bit;

        public string Bit => $"{(bit/bitsInBits):N0}Bit";
        public string Byte => $"{(bit / bitsInByte):N0}Byte";
        public string KB => $"{(bit / bitsInKB):N0}KB";
        public string MB => $"{(bit / bitsInMB):N0}MB";
        public string GB => $"{(bit / bitsInGB):N0}GB";
        public string TB => $"{(bit / bitsInTB):N0}TB";

        private const long bitsInBits = 1;
        private const long bitsInByte = 8;
        private const long bitsInKB = bitsInByte*1024;
        private const long bitsInMB = bitsInKB*1024;
        private const long bitsInGB = bitsInMB*1024;
        private const long bitsInTB = bitsInGB*1204;

        public DigitalSize(long initialValue)
        {
            this.bit = initialValue;
        }

        public DigitalSize AddBit(long bit) => Add(bit, bitsInBits);
        public DigitalSize AddByte(long bit) => Add(bit, bitsInByte);
        public DigitalSize AddKB(long bit) => Add(bit, bitsInKB);
        public DigitalSize AddMB(long bit) => Add(bit, bitsInMB);
        public DigitalSize AddGB(long bit) => Add(bit, bitsInGB);
        public DigitalSize AddTB(long bit) => Add(bit, bitsInTB);

        public DigitalSize Add(long value, long scale) => new DigitalSize(value * scale);

    }

    

    //User defined type (class,struct)

    /*
     What is the deferent between class and struct ?
    _________________________________________________

    1.Keyword struct/class
    2.struct consructor cant't build with parameter
    3.struct field can't have intilize value and override
    4.can't have finalizer
    5.doesn't support inhertince

    *You can chnge the values in class but you can't do the same with the struct
    *Emutable
     */
}
