﻿using System;

namespace SumDigits
{
	class SumDigits
	{
		static void Main()
		{
			int input = int.Parse(Console.ReadLine());
			int sum = 0;

			while (input > 0)
			{
				sum += input % 10;
				input /= 10;
			}
			Console.WriteLine(sum);
		}
	}
}
