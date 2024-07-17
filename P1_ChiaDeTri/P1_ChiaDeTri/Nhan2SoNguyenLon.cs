using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P1_ChiaDeTri
{
    class nhan2SoNguyenLon
    {
        public static void Main(string[] args)
        {
            string num1 = "12345678901234567890";
            string num2 = "98765432109876543210";
            BigInteger result = MultiplyBigIntegers(num1, num2);
            Console.WriteLine("Result: "+result);
            Console.ReadLine();
        }

        public static BigInteger MultiplyBigIntegers(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return 0;

            if (num1.Length < 4 || num2.Length < 4)
                return new BigInteger(long.Parse(num1)) * new BigInteger(long.Parse(num2));

            int mid1 = num1.Length / 2;
            int mid2 = num2.Length / 2;

            string a = num1.Substring(0, mid1);
            string b = num1.Substring(mid1);
            string c = num2.Substring(0, mid2);
            string d = num2.Substring(mid2);

            BigInteger p1 = MultiplyBigIntegers(a, c);
            BigInteger p2 = MultiplyBigIntegers(a, d);
            BigInteger p3 = MultiplyBigIntegers(b, c);
            BigInteger p4 = MultiplyBigIntegers(b, d);

            return p1 * (BigInteger)Math.Pow(10, mid1 * 2) + (p2 + p3) * (BigInteger)Math.Pow(10, mid1) + p4;

        }

    }
}
