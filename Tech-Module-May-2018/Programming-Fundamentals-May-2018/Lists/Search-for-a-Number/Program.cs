﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            int[] searchArr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int takeAmount = searchArr[0];
            int skipAmount = searchArr[1];
            int searchFor = searchArr[2];
            var modifiedInput = input.Take(takeAmount).Skip(skipAmount).ToList();
            if (modifiedInput.Contains(searchFor))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
