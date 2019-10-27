using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Child : Base
    {
        // Demonstrate overriding a base class method by a child
        public override void PrintClass()
        {
            Console.WriteLine("I'm a child object. Goo.");
        }

        // Demonstrate a child method calling the parent's method
        public override void ParentsMethod()
        {
            base.ParentsMethod();
            Console.WriteLine("Child.ParentsMethod");
        }
    }
}
