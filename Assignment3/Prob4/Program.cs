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
            Base BaseObject = new Base();
            Child ChildObject = new Child();

            Base[] Array = { BaseObject, ChildObject };
            #endregion

            #region base class method called from child object
            ChildObject.PrintHello();
            #endregion
        }
    }
}
