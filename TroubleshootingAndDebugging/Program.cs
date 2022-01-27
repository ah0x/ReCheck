using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroubleshootingAndDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = 1000;
            var member = 2;

            member = reduce(member, 2);

            var share = Distribute(amount, member);

            decimal f = FtoC(0);
            Console.WriteLine($"{0}c to {f}f");

            decimal c = CtoF(32);
            Console.WriteLine($"{32}f to {c}c");

            Console.ReadKey();
        }

        static int reduce(int member, int value)
        {
            return member -= value;
        }

        static int Distribute(int amount,int member)
        {
            try
            {
                return amount / member;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpactedd Error: {ex.Message}");
            }
            return 0;
        }

        static decimal FtoC(decimal c)
        {
            decimal f = 0m;
            f = (c * 9 / 5) + 32;
            return f;
        }

        static decimal CtoF(decimal f)
        {
            decimal c = 0m;
            c = (f -32) * 5 / 9;
            return c;
        }
    }
}

/*

There are 3 Types of Errors
___________________________
    
    A) Syntax Error   ->  occur while coding
    B) Run Time Error ->  improper user input,improper desgin logic or system error
    C) Logical Error  ->  program work fine but not return the correct result
     
    The Exception is the event that occur in (B) and that can't controled by computer
*/
