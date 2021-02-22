using System;
using System.Collections.Generic;
using System.Text;

namespace UnitsNet.CustomCode
{
    internal static class CustomMath
    {
        public static readonly decimal PI = CalcPI();

        private static decimal CalcPI()
        {
            return 2 * F(1);
        }
        private static decimal F(int i)
        {
            if (i > 60)
                return i;
            else
                return 1 + (i / (1 + (2.0m * i))) * F(i + 1);
        }
    }
}
