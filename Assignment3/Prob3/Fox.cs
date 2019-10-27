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
            // demonstrate aggregation
            this.name = name;

            // demonstrate composition
            bodyParts = new string[] { "Tail", "Legs", "Ears", "Eyes", "Nose", "Mouth" };
        }

        public void printState()
        {
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
