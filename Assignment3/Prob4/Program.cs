/*
Author: Torin Tashima
Date:   October 19, 2019
CTEC 135: Microsoft Software Development with C#

Module 4, Programming Assignment 3, Problem 4

    Demo Class Hierarchy

- Create a hierarchy of classes that demonstrates polymorphic behavior in the
    following situation
    - An array of the base class type is created and initialized with a member
        of each class in the hierarchy
    - Show that a method belonging to the base class is called from a child
        instance
    - Demonstrate overriding a base class method by a child
    - Demonstrate a child method calling the parent's method
    - Demonstrate use of "as" keyword
    - Demonstrate use of "is" keyword
    - Demonstrate calling a method in a for loop iterating over the instances
        in the array
    - Demonstrate calling a method in a foreach loop
    - Demonstrate switch statement that responds differently depending upon the
        type of the object
    - Create an object of "object" type, but initialized of the base class type,
        then cast it to the actual type so you can call a method
    - Create an object of the base class type but initialized to a child type
        that has a specialized method. Call the specialized method by using
        casting

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array of every member of classes in hierarchy
            Base[] ObjectArray = { new Base(), new Child() };
            #endregion

            #region base class method called from child object
            Console.WriteLine("Demonstrate base method called from child object");
            // demonstrate iteration through for loop
            for (int i = 0; i < ObjectArray.Length; i++)
            {
                Console.Write("{0}: ", ObjectArray[i].GetType());
                ObjectArray[i].BaseMethod();
            }
            Console.WriteLine();
            #endregion

            #region demonstrate method overriding
            Console.WriteLine("Demonstrate base method overriden by child class");
            // demonstrate iteration through foreach loop
            foreach (Base Object in ObjectArray)
            {
                Console.Write("{0}: ", Object.GetType());
                Object.PrintClass();
            }
            Console.WriteLine();
            #endregion

            #region demonstrate child method calling parent's method
            Console.WriteLine("Demonstrate child method calling parent's method");
            foreach (Base Object in ObjectArray)
            {
                Console.Write("{0}: ", Object.GetType());
                Object.ParentsMethod();
            }
            Console.WriteLine();
            #endregion

            #region demonstrate use of "as" keyword
            Console.WriteLine("Demonstrate use of \"as\" keyword");
            foreach (Base Object in ObjectArray)
            {
                Base b = Object as Base;
                Console.Write("{0}: ", b.GetType());
                b.PrintClass();
            }
            Console.WriteLine();
            #endregion

            #region demonstrate use of "is" keyword
            Console.WriteLine("Demonstrate use of \"is\" keyword");
            foreach (Base Object in ObjectArray)
            {
                if (Object is Child)
                {
                    Console.WriteLine("Child");
                }
                else if (Object is Base)
                {
                    Console.WriteLine("Base");
                }
            }
            Console.WriteLine();
            #endregion
        }
    }
}
