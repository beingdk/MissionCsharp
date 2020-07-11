using System;
using System.Linq;
using System.Reflection;

namespace tests
{
	class Program
	{
		static void Main(string[] args)
		{
            string[] values = { "10","4","5" };
            int additionalRecordsClient = 2;
            int additionalRecordsEmployee = 1;
            if (values.Length > 1)
            {
                additionalRecordsClient = !(string.IsNullOrWhiteSpace(values[1]) || Convert.ToInt32(values[1]) <= 0) ? Convert.ToInt32(values[1]) : 2;
                if (values.Length > 2)
                {
                    additionalRecordsEmployee = !(string.IsNullOrWhiteSpace(values[2]) || Convert.ToInt32(values[2]) <= 0) ? Convert.ToInt32(values[2]) : 1;
                }
            }
            var output = Format("786","hgj");
			Console.WriteLine("'{0}'",output);
            var ab = "5678";
            var lol = ab.PadLeft(10, '0');
            Console.WriteLine("'{0}'", lol);
        }
        public  decimal Client_TotalSUITaxablePlusTotalSUIExcess { get; set; }
        public static string Format(string input, string data = "", object classObject = null)
        {
            input = data;
            return input;
        }
        
    }
}
