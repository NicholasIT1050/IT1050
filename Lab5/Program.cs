﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Fido";
            myDog.trickName = "Trick";

            // To do: uncomment the following lines of code to call the methods
            myDog.Bark();
            myDog.DoTrick();
            Console.ReadLine();
        }
    }
}
