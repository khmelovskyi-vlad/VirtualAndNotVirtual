using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndNotVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            var b = new B();
            var c = new C();
            a.Foo();
            b.Foo();
            c.Foo();
            A[] arr = new[] {a, b, c};
            foreach (A item in arr)
            {
                item.Foo();
            }
            foreach (A item in arr)
            {
                item.FooVirtual();
            }
            Console.ReadKey();
        }
    }
}
