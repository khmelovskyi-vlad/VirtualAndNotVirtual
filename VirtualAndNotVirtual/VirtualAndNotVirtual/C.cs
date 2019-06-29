using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndNotVirtual
{
    class C : B
    {
        public new void Foo()
        {
            Console.WriteLine(nameof(C));
        }
        public override void FooVirtual()
        {
            Console.WriteLine(nameof(C));
        }
    }
}
