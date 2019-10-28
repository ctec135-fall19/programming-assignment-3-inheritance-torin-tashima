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

        // PrintClass IPO
        // Input:   N/A
        // Process: Call Console.WriteLine() to print out a message.
        // Output:  Print "I'm a child object. Goo."
        public override void PrintClass()
        {
            Console.WriteLine("I'm a child object. Goo.");
        }

        // Demonstrate a child method calling the parent's method

        // ParentsMethod IPO
        // Input:   N/A
        // Process: Call Console.WriteLine() to print out a message.
        // Output:  Print "Child.ParentsMethod"
        public override void ParentsMethod()
        {
            base.ParentsMethod();
            Console.WriteLine("Child.ParentsMethod");
        }
    }
}
