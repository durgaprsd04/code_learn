﻿using System;

namespace LeetCode2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n =2147483648;
            Console.WriteLine($"Hello World! {(n&(n-1))}");

        }
    }
}
