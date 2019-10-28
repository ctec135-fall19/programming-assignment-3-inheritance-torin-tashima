using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Fox
    {
        // fields
        private string name;
        private string[] bodyParts;

        public Fox(string name)
        {
            // Fox Class IPO
            // Input:   A string argument named name.
            // Process: Pass in value of name argument to the Fox's name field.
            // Output:  N/A

            // demonstrate aggregation
            this.name = name;

            // demonstrate composition
            bodyParts = new string[] { "Tail", "Legs", "Ears", "Eyes", "Nose", "Mouth" };
        }

        public void printState()
        {
            // printState method IPO
            // Input:   N/A
            // Process: Get fox object's name and list of body parts.
            //          A foreach loop is used to iterate through body parts.
            // Output:  Print fox's name and list of body parts.

            // aggregation - printing
            Console.WriteLine("Fox's name: {0} ", name);

            // composition - printing
            Console.Write("A fox has: ");
            foreach (string bodyPart in bodyParts)
            {
                Console.Write("{0} ", bodyPart);
            }

            Console.WriteLine();
        }
    }
}
