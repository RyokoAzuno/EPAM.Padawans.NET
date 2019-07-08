using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            // put your code here
            //throw new NotImplementedException();
            if (a == 0 && b == 0)
                throw new ArgumentException();

            if (a == 0 && b > 0)
                return b;
            else if (b == 0 && a > 0)
                return a;

            if (a < 0)
            {
                a = Math.Abs(a);
                if (b == 0)
                    return a;
            }
            if (b < 0)
            {
                b = Math.Abs(b);
                if (a == 0)
                    return b;
            }

            int[] arr = BinaryGcd(a, b);
            int result = arr[0] * Convert.ToInt32(Math.Pow(2, arr[1]));

            return result;
        }
        // An alternative method of computing the gcd, method which uses only subtraction and division by 2
        // gcd(a, b) = g * 2^d
        // BinaryGCD: https://en.wikipedia.org/wiki/Greatest_common_divisor
        private static int[] BinaryGcd(int a, int b)
        {
            int[] result = new int[2];
            int g = 0;
            int d = 0;
            if(a > 0 && b > 0)
            {
                // Both a and b are even.
                // In this case 2 is a common divisor. Divide both a and b by 2, increment d by 1
                // to record the number of times 2 is a common divisor and continue.
                while ((a % 2 == 0) && (b % 2 == 0))
                {
                    a = a / 2;
                    b = b / 2;
                    ++d;
                }
                while(a != b)
                {
                    if (a % 2 == 0)         // In this case 2 is not a common divisor. Divide a by 2 and continue.
                        a = a / 2;
                    else if (b % 2 == 0)    // As in the previous case 2 is not a common divisor. Divide b by 2 and continue.
                        b = b / 2;
                    else if (a > b)         // As gcd(a,b) = gcd(b,a) and consider that a = b, we may assume that a > b.
                        a = (a - b) / 2;    // Each of the above steps reduces at least one of a and b towards 0 and so can only 
                    else                    // be repeated a finite number of times. 
                        b = (b - a) / 2;    // Thus one must eventually reach the case a = b, which is the only stopping case.
                }
                g = a;
            }
            result[0] = g;
            result[1] = d;
            return result;
        }
    }
}
