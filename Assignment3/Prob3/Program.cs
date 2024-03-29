﻿/*
Author: Torin Tashima
Team:   Torin Tashima and Katrina Voll-Taylor
Date:   October 19, 2019
CTEC 135: Microsoft Software Development with C#

Module 4, Programming Assignment 3, Problem 3

    Aggregation and Composition

- Demonstrate both the aggregation and composition relationships.
- In your write-up:
    - Define these relationships in your own words. Do a little research on the
        internet to see how other people define these terms. How does your
        definition compare to other definitions (site sources/links)?
    - What is the difference between these two relationships?

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            // String object used to demonstrate aggregation
            // Will still exist even when Fox object is destroyed
            string foxName = "Reynard";

            // Create object of Fox class
            Fox reynard = new Fox(foxName);

            // Print Reynard's state: name and body parts
            reynard.printState();
        }
    }
}