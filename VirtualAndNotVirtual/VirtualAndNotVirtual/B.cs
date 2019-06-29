using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndNotVirtual
{
    class B : A
    {
        public new void Foo()
        {
            Console.WriteLine(nameof(B));
        }
        public override void FooVirtual()
        {
            Console.WriteLine(nameof(B));
        }
    }
}
