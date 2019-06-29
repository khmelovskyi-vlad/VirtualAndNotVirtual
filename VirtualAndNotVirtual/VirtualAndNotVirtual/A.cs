using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndNotVirtual
{
    class A
    {
        public void Foo()
        {
            Console.WriteLine(nameof(A));
        }
        public virtual void FooVirtual()
        {
            Console.WriteLine(nameof(A));
        }
    }
}
