using System;
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
		/// <summary>
		/// Usage: add num[1] num[2] . . . num[n]
		/// </summary>
		public static int Add(string[] numbers)
		{
			return ConvertStrArrayToIntArray(numbers).Sum();
		}

		/// <summary>
		/// Usage: subtract num[1] num[2] . . . num[n]
		/// </summary>
		public static int Subtract(string[] numbers)
		{
			int[] n = ConvertStrArrayToIntArray(numbers);
			int result = n[1];

			for (int i = 2; i < n.Length; i++)
			{
				result -= n[i];
			}

			return result;
		}

		/// <summary>
		/// Usage: multiply num[1] num[2] . . . num[n]
		/// </summary>
		public static int Multiply(string[] numbers)
		{
			int[] n = ConvertStrArrayToIntArray(numbers);
			int result = n[1];

			for (int i = 2; i < n.Length; i++)
			{
				result *= n[i];
			}

			return result;
		}

		/// <summary>
		/// Usage: divide num[1] num[2] . . . num[n]
		/// </summary>
		public static int Divide(string[] numbers)
		{
			int[] n = ConvertStrArrayToIntArray(numbers);
			int result = n[1];

			for (int i = 2; i < n.Length; i++)
			{
				result /= n[i];
			}

			return result;
		}

		/// <summary>
		/// Converts a string[] array into an int[] array
		/// </summary>
		public static int[] ConvertStrArrayToIntArray(string[] arrayString)
		{
			int[] n = new int[arrayString.Length];

			for (int i = 1; i < arrayString.Length; i++)
			{
				int.TryParse(arrayString[i], out n[i]);
			}

			return n;
		}
	}
}
