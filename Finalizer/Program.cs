using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Scope 1
                Person p = new Person();
                p.Name = "Ali";

                //Object flagged to be destroud when it will be in end of its scoped
            }
            /*
                Garbage collection -> Automatic memory mangment
                When obgect get desposed ?

                A) End of program
                B) When Memory get full(implict)
                C) GO.Collect(explict) call by programmer
            */

            {
                //Scope2
            }
            MakeGarabge();
            Console.WriteLine($"Memory used Before collection {GC.GetTotalMemory(false):N0}");//force to not clean
            GC.Collect();//Explict Cleanning
            Console.WriteLine($"Memory used After collection {GC.GetTotalMemory(true):N0}");//force to clean
            Console.ReadKey();
        }

        static void MakeGarabge()
        {
            Version v;
            for (int i = 0; i < 1000; i++)
            {
                v = new Version();
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public Person()
        {
            Console.WriteLine("Person Class Constructor");
        }

        ~Person()
        {
            Console.WriteLine("Person Class Destructor");
        }
    }
}
