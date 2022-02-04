using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Month.MAR);//MAR
            Console.WriteLine((long)Month.MAR);//print the value = 61
            Console.WriteLine("-------------------------------------");

            var holday = (Day.SATURDAY | Day.SUNDAY);
            if(holday.HasFlag(Day.WEEKEND))
            {
                Console.WriteLine("Enjoy Your WeekEnd");
            }

            var day = "n";//feb will make erroe => feb is not found.
            //Console.WriteLine(Enum.Parse(typeof(Month),day));

            if(Enum.TryParse(day,out Month month))
            {
                Console.WriteLine(month);
            }
            else if (Enum.IsDefined(typeof(Month), day))
            {
                Console.WriteLine(month);
            }
            else
            {
                Console.WriteLine("not Found");
            }

            Console.WriteLine((long)Day.BUSDAY);


            //foreach (var months in Enum.GetNames(typeof(Month)))
            //{
            //    Console.WriteLine($"{months} = {(int)Enum.Parse(typeof(Month), months)}");
            //} must remove the :long in 53 line to work

            Console.ReadKey();
        }
    }

    // Is varbile type that you can use it to make group of varbiles.
    // this is simple Enum
    enum Month:long //:int by defult 
    {
        //if you don't give value the enum type will start to give +1 for every one by defult
        // or make +1 on the first varbile if others is empty
        JAN = 1, //0
        FEB, //1
        MAR, //2
        APR,
        MAY,
        JUN,
        JUL,
        AUG,
        SEP,
        OCT,
        NOV,
        DEC
    }

    //Flags Enum : take more than one select in the ssane time
    [Flags]
    enum Day
    {
        NONE     = 0b_0000_0000, //this is binary represnt in DotNet and mean 0
        MONDAY   = 0b_0000_0001,
        TUESDAY  = 0b_0000_0010,
        WEDNSDAY = 0b_0000_0100,
        THURSDAY = 0b_0000_1000,
        FRIDAY   = 0b_0001_0000,
        SATURDAY = 0b_0010_0000,
        SUNDAY   = 0b_0100_0000,
        BUSDAY   = MONDAY | TUESDAY | WEDNSDAY | THURSDAY | FRIDAY,
        WEEKEND  = SATURDAY | SUNDAY,
    }
}
