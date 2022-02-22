using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("Ali Hamza");
            Console.WriteLine("");

            var numbers = new Any<object>();
            numbers.Add(0);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.DisplayList();
            Console.WriteLine($"Length: {numbers.Count} items");
            Console.WriteLine("");
            numbers.RemoveAt(2);
            numbers.DisplayList();
            Console.WriteLine($"Length: {numbers.Count} items");
            Console.WriteLine($"Empty: {numbers.IsEmpty}");
            Console.WriteLine("");

            var people = new Any<person>();
            people.Add(new person { FName = "Ali" , LName = "Hamza" });
            people.Add(new person { FName = "Ahmed" , LName = "Hamza" });
            people.Add(new person { FName = "Mohammed" , LName = "Hamza" });
            people.Add(new person { FName = "Zaid" , LName = "Hamza" });
            people.DisplayList();
            Console.WriteLine($"Length: {people.Count} items");
            Console.WriteLine($"Empty: {people.IsEmpty}");
            Console.WriteLine("");

            //this work is built by microsoft can be reached in generic
            var person2 = new List<person>();

            //this work is built by microsoft can be reached in Collection and is different from generic there is no type save
            var arr = new ArrayList();
            arr.Add(1);
            arr.Add("Keep Going your battle");
            arr.Add(new { Fname = "Mohammed", Lname = "Hamza" });
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Length: {arr.Count} items");
            Console.WriteLine($"Empty: {arr.Count==0}");
            Console.ReadKey();
        }

        static void Print<T>(T Value)
        {
            Console.WriteLine($"DataType{typeof(T)}");
            Console.WriteLine(Value);
        }
    }

    public class person
    {
        public string FName { get; set; }

        public string LName { get; set; }

        public override string ToString()
        {
            return $"'{FName} {LName}'";
        }
    }

    //that mean the Parameter Type must be class and accept another constraint
    class Any<T> where  T : class,new()
    {
        private T[] _Items;

        public void Add(T item)
        {
            if(_Items is null)
            {
                _Items = new T[] { item };
            }
            else
            {
                var length = _Items.Length;
                var dest = new T [ length + 1 ];
                for (int i = 0; i < length; i++)
                {
                    dest[i] = _Items[i];
                }
                dest[dest.Length - 1] = item;
                _Items = dest;
            }
        }

        public void RemoveAt(int position)
        {
            if (position < 0 || position > _Items.Length - 1) // this is not the best practise
                return;

            var index = 0;
            var dest = new T[_Items.Length - 1];

            for (int i = 0; i < _Items.Length; i++)
            {
                if (position == i)
                    continue;
                dest[index++] = _Items[i];
            }
            _Items = dest;
        }

        public bool  IsEmpty => _Items is null || _Items.Length == 0;

        public int Count => _Items is null ? 0 : _Items.Length;

        public void DisplayList()
        {
            Console.Write("[");
            for (int i = 0; i < _Items.Length; i++)
            {
                Console.Write(_Items[i]);
                if (i < _Items.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }
    }
}
