using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Base
    {
        public void PrintHello()
        {
            Console.WriteLine("hello");
        }
        public virtual void PrintAnimal()
        {
            Console.WriteLine("dog");
        }
    }
}
