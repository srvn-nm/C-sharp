using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;//0_255
            sbyte b = 127;//-128_127
            short c = 32767;//-32768_32767
            ushort d = 65535;//0_65535
            int e = 2147483647;//-2147483648_2147483647
            uint f = 4294967295;//0_4294967295
            long g = 9223372036854775807;//-9223372036854775808_9223372036854775807
            ulong h = 18446744073709551615;//0_18446744073709551615
            float i = 1;//-3.402823e38_3.402823e38
            double j = 5.6;//5.0 * 10-324 - 1.7 * 10308
            decimal k = 0;//-7.9 * 10?28 - 7.9 * 1028
            char l = 'a'; 
            bool m = true;
            object n = null;
            string o = "h";
            DateTime dateTime = DateTime.Now;
        }
    }
}
