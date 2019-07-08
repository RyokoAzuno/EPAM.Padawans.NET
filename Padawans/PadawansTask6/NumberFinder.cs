using System;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            // put your code here
            if (number < 0 || number > int.MaxValue)
                throw new ArgumentException();

            string str = number.ToString();
            int tmp = number + 1;

            int[] zeroes = NumberOfZeroes(str);
            if ((zeroes[1] == 1) || IsConsistOfTheSameDigit(str))
                return null;

            while (tmp < int.MaxValue)
            {
                string s = tmp.ToString();
                if (str.Length < s.Length)
                {
                    break;
                }
                if (s.Length == str.Length)
                {
                    if (IsEqual(str, s))
                    {
                        return int.Parse(s);
                    }
                }
                tmp++;
            }
            return null;
        }
        /// <summary>
        /// Check if str1 == str2
        /// </summary>
        /// <param name="str1">First string</param>
        /// <param name="str2">Second string</param>
        /// <returns>true if str1 == str2 and false otherwise</returns>
        private static bool IsEqual(string str1, string str2)
        {
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }
        private static int[] NumberOfZeroes(string str)
        {
            int[] result = new int[2];
            int numOfZeroes = 0;
            int numOfNotZeroes = 0;
            foreach (var item in str)
            {
                if (item == '0')
                    ++numOfZeroes;
                else
                    ++numOfNotZeroes;
            }
            result[0] = numOfZeroes;
            result[1] = numOfNotZeroes;

            return result;
        }
        private static bool IsConsistOfTheSameDigit(string str)
        {
            int count = 0;
            char pattern = str[0];
            foreach (var item in str)
            {
                if (item == pattern)
                    ++count;
            }
            if (str.Length == count)
                return true;

            return false;
        }
    }
}
