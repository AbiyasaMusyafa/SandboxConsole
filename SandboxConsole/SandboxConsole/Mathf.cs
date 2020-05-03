﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandboxing
{
	/// <summary>
	/// Mathematical function library.
	/// </summary>
	class Mathf
	{
		public static string[] mathcmd = new string[4] 
		{ 
			"add", "subtract", "multiply", "divide"
		};

		/// <summary>
		/// Usage: add num[1] num[2] . . . num[n]
		/// </summary>
		public static double Add(string[] numbers)
		{
			return ConvertStrArrayToIntArray(numbers).Sum();
		}

		/// <summary>
		/// Usage: subtract num[1] num[2] . . . num[n]
		/// </summary>
		public static double Subtract(string[] numbers)
		{
			double[] n = ConvertStrArrayToIntArray(numbers);
			double result = n[1];

			for (int i = 2; i < n.Length; i++)
			{
				result -= n[i];
			}

			return result;
			n = null;
		}

		/// <summary>
		/// Usage: multiply num[1] num[2] . . . num[n]
		/// </summary>
		public static double Multiply(string[] numbers)
		{
			double[] n = ConvertStrArrayToIntArray(numbers);
			double result = n[1];

			for (int i = 2; i < n.Length; i++)
			{
				result *= n[i];
			}

			return result;
			n = null;
		}

		/// <summary>
		/// Usage: divide num[1] num[2] . . . num[n]
		/// </summary>
		public static double Divide(string[] numbers)
		{
			double[] n = ConvertStrArrayToIntArray(numbers);
			double result = n[1];

			for (int i = 2; i < n.Length; i++)
			{
				result /= n[i];
			}

			return result;
			n = null;
		}

		/// <summary>
		/// Converts a string[] array into an int[] array
		/// </summary>
		public static double[] ConvertStrArrayToIntArray(string[] arrayString)
		{
			double[] n = new double[arrayString.Length];

			for (int i = 1; i < arrayString.Length; i++)
			{
				double.TryParse(arrayString[i], out n[i]);
			}

			return n;
			n = null;
		}
	}
}
