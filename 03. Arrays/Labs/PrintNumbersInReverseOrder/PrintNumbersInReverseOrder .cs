﻿using System;

namespace PrintNumbersInReverseOrder
{
    class PrintNumbersInReverseOrder
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] inputArray = new int[number];
            for (int i = 0; i < number; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                Console.Write(inputArray[i] + " ");
            }
        }
    }
}