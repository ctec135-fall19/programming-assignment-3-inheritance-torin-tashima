using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Phone
    {
        // fields
        private string name;
        private string carrier;
        private int gigs;
        private Calculator calc = new Calculator();
        //private Clock clock = new Clock();

        // constructors
        public Phone()
        {
            name = "Cell";
            carrier = "Horizon";
            gigs = 64;
        }

        public Phone(string name, string carrier, int gigs)
        {
            this.name = name;
            this.carrier = carrier;
            this.gigs = gigs;
        }

        // methods
        public void Calculate()
        {
            Console.Write("What would you like to do? ");
            string command = Console.ReadLine();

            switch (command)
            {
                case "add":
                    Console.Write("Enter first number: ");
                    string input1 = Console.ReadLine();
                    Console.Write("Enter second number: ");
                    string input2 = Console.ReadLine();
                    int int1 = Int32.Parse(input1);
                    int int2 = Int32.Parse(input2);
                    Console.Write("The answer is: ");
                    Console.WriteLine(calc.Add(int1, int2));
                    break;
                case "subtract":
                    Console.Write("Enter first number: ");
                    input1 = Console.ReadLine();
                    Console.Write("Enter second number: ");
                    input2 = Console.ReadLine();
                    int1 = Int32.Parse(input1);
                    int2 = Int32.Parse(input2);
                    Console.Write("The answer is: ");
                    Console.WriteLine(calc.Subtract(int1, int2));
                    break;
            }
        }
    }
}
