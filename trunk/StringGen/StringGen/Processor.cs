using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringGen
{
	class Processor
	{
		/// <summary>
		/// Generates a string given a start number and an end number, surrounded with specified strings.
		/// </summary>
		/// <param name="startNumber"></param>
		/// <param name="endNumber"></param>
		/// <param name="leftSurround"></param>
		/// <param name="rightSurround"></param>
		/// <returns></returns>
		internal string generateStringIterativeFormat(int startNumber, int endNumber, string leftSurround, string rightSurround)
		{
			return generateStringIterativeFormat(startNumber, endNumber, leftSurround, rightSurround, "");
		}

		/// <summary>
		/// Generates a string given a start number and an end number, surrounded with specified strings and separated with specified separator.
		/// </summary>
		/// <param name="startNumber"></param>
		/// <param name="endNumber"></param>
		/// <param name="leftSurround"></param>
		/// <param name="rightSurround"></param>
		/// <param name="separator"></param>
		/// <returns></returns>
		private string generateStringIterativeFormat(int startNumber, int endNumber, string leftSurround, string rightSurround, string separator)
		{
			if (startNumber > endNumber)
				throw new ArgumentException("startNumber is bigger than endNumber");

			string res = "";

			for (int i = startNumber; i <= endNumber; i++)
			{
				res += leftSurround + i + rightSurround + separator;
			}

			return res;
		}
	}
}
