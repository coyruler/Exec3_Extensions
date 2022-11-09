using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
		static void Main(string[] args)
		{

			string value = "1234";
			int value2 = 10000;
			var result =value.ToInt(-1);
			Console.WriteLine(result);
			value = "123asd";
			result = value.ToInt(-1);
			Console.WriteLine(result);			
		}
    }
	public static class convert
	{
		public static int ToInt(this string value, int defaultvalue)
		{
			if(Int32.TryParse(value, out int result))
			{
				return result;
			}
			else return defaultvalue;
		}
	}
}
