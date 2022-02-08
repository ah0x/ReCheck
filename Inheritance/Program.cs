using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
- why inheritance?
reusabilty,maintainabilty,extensibilityvically

*class can't inhranrte more than one class
*abstract make the class just for inheritance and must contain abstract members
*sealed class can't inhrerited
*virtual that mean you can in subclass modifiy the method that is in base class
*abstract member is only declerd in base class
*you can't makw the inheritance directly on constrocter you must make base constrocter call the sub constrocter
 */

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager
            {
                Id = 1,
                Name = "Ali Hamza",
                LoggedHours = 180,
                wage=10
            };

            Console.WriteLine(m);

            Console.ReadKey();
            {
                // this is upCasting
                //var e = new Egale();
                //Animal a = e;

                ////this is downCasting
                //Egale e2 = (Egale)a; //excplict cast

                //e.Move();

                //Animals animals = new Animals();
                //animals.Name = "Egale";
                //Console.WriteLine(animals);

                //SubClass S = new SubClass(1);
            }
        }
    }

    class Animals
    {
        public string  Name { get; set; }

        public void Move()
        {
            Console.WriteLine($"Animal: {Name} is Moving");
        }

        public override string ToString()
        {
            return $"Animal: {Name}";
        }
    }

    abstract class Animal
    {
        public string Name { get; set; }
        public abstract void Move();
        //{
        //    Console.WriteLine("Moving");
        //}
    }

    sealed class Egale:Animal
    {
        public override void Move()
        {
            //this call class member
            //base call base class member
            //base.Move();
            Console.WriteLine("The Egale");
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }

    class BaseClass
    {
        public int x;

        public BaseClass()
        {

        }

        public BaseClass(int value)
        {
            x = value;
        }
    }

    class SubClass:BaseClass
    {
        public SubClass(int ScValue):base(ScValue)
        {

        }
    }
}


