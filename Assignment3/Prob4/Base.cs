using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Base
    {
        // Show that a method belonging to the base class is called from a
        // child instance
        public void BaseMethod()
        {
            Console.WriteLine("This is a base method.");
        }

        // Demonstrate overriding a base class method by a child
        public virtual void PrintClass()
        {
            Console.WriteLine("I'm a base object!");
        }

        // Demonstrate a child method calling the parent's method
        public virtual void ParentsMethod()
        {
            Console.WriteLine("Base.ParentsMethod");
        }
    }
}
