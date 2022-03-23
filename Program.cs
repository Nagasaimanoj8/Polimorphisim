﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating...");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("eating bread...");
        }

    }
    public class TestPolymorphism
    {
        public static void Main()
        {
            Animal a = new Dog();
            a.eat();
        }
    }
}
