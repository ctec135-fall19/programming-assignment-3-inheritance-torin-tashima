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

        // BaseMethod IPO
        // Input:   N/A
        // Process: Call Console.WriteLine() to print out a message.
        // Output:  Print "This is a base method."
        public void BaseMethod()
        {
            Console.WriteLine("This is a base method.");
        }

        // Demonstrate overriding a base class method by a child

        // PrintClass IPO
        // Input:   N/A
        // Process: Call Console.WriteLine() to print out a message.
        // Output:  Print "I'm a base object!"
        public virtual void PrintClass()
        {
            Console.WriteLine("I'm a base object!");
        }

        // Demonstrate a child method calling the parent's method

        // ParentsMethod IPO
        // Input:   N/A
        // Process: Call Console.WriteLine() to print out a message.
        // Output:  Print "Base.ParentsMethod"
        public virtual void ParentsMethod()
        {
            Console.WriteLine("Base.ParentsMethod");
        }
    }
}
