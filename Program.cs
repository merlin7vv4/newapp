﻿

using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
           int [] mang = {1,3,423,23,97};
           foreach (var cacphantu in mang)
           {
            Console.WriteLine(cacphantu);
           }
        }
    }
}
string[] names = { "John", "Paul", "George", "Ringo" };

for (int i = names.Length-1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
