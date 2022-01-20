using System;
using System.Numerics;

namespace BOJ_24309
{
    internal static class MainApp
    {
        private static void Main(string[] args)
        {
            var la = Console.ReadLine();
            var a = BigInteger.Parse(la);

            var lb = Console.ReadLine();
            var b = BigInteger.Parse(lb);

            var lc = Console.ReadLine();
            var c = BigInteger.Parse(lc);

            Console.WriteLine((b - c) / a);
        }
    }
}