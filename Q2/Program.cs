using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "5245278";

            string value2 = "as";
            string value3=string.Empty;

            string result4 = value.Left(999);
            Console.WriteLine(result4);
            result4 = value2.Left(1);
            Console.WriteLine(result4);
            result4 = value3.Left(2);
            Console.WriteLine(result4);
            result4 = value2.Left(-999);
            Console.WriteLine(result4);
        }
    }
    public static class StringLenngth
    {
        public static string Left(this string source, int length)
        {
            if (string.IsNullOrEmpty(source)) return string.Empty;
            if (length <= 0) return string.Empty;
            if (source.Length <= length) return source;

            return source.Substring(0, length);
        }
    }
}
