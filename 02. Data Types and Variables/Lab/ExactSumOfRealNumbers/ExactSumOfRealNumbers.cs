﻿using System;

namespace ExactSumOfRealNumbers
{
	class ExactSumOfRealNumbers
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			decimal sum = 0;
			for (int i = 0; i < n; i++)
			{
				sum += decimal.Parse(Console.ReadLine());
			}
			Console.WriteLine(sum);
		}
	}
}
