/*
Author: Torin Tashima
Team:   Torin Tashima and Katrina Voll-Taylor
Date:   October 19, 2019
CTEC 135: Microsoft Software Development with C#

Module 4, Programming Assignment 3, Problem 4

    Polymorphic Behavior Demos

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
            foreach (Base Obj in ObjectArray)
            {
                Console.Write("{0}: ", Obj.GetType());
                Obj.PrintClass();
            }
            Console.WriteLine();
            #endregion

            #region demonstrate child method calling parent's method
            Console.WriteLine("Demonstrate child method calling parent's method");
            foreach (Base Obj in ObjectArray)
            {
                Console.Write("{0}: ", Obj.GetType());
                Obj.ParentsMethod();
            }
            Console.WriteLine();
            #endregion

            #region demonstrate use of "as" keyword
            Console.WriteLine("Demonstrate use of \"as\" keyword");
            foreach (Object Obj in ObjectArray)
            {
                Base b = Obj as Base;
                Console.Write("{0}: ", b.GetType());
                b.PrintClass();
            }
            Console.WriteLine();
            #endregion

            #region demonstrate use of "is" keyword
            Console.WriteLine("Demonstrate use of \"is\" keyword");
            foreach (Base Obj in ObjectArray)
            {
                if (Obj is Child)
                {
                    Console.WriteLine("Child");
                }
                else if (Obj is Base)
                {
                    Console.WriteLine("Base");
                }
            }
            Console.WriteLine();
            #endregion

            #region switch statement
            Console.WriteLine("Demonstrate use of switch statement");
            foreach (Base Obj in ObjectArray)
            {
                switch (Obj)
                {
                    case Child c:
                        Console.WriteLine("switch Child");
                        break;
                    case Base b:
                        Console.WriteLine("switch Base");
                        break;
                    default:
                        Console.WriteLine("switch default");
                        break;
                }
            }
            Console.WriteLine();
            #endregion

            #region create object of object type and initialize to base type
            Console.WriteLine("Demonstrate casting of object types");

            // first initialize "object" object to the "base" class type
            Object newObject = new Base();

            // then cast "object" object as a "base" object to call a method
            Console.Write("{0}: ", newObject.GetType());
            ((Base)newObject).PrintClass();
            #endregion

            #region create object of base type and initialize to child type
            // first initialize "base" object to the "child" class type
            Base bassGuitar = new Child();

            // then cast "base" object as a "child" object to call a method
            Console.Write("{0}: ", bassGuitar.GetType());
            ((Child)bassGuitar).PrintClass();
            #endregion
        }
    }
}
