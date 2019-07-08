using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            // put your code here
            // throw new NotImplementedException();
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length == 0)
                throw new ArgumentException();
            if ((accuracy <= 0) || (accuracy >= 1))
                throw new ArgumentOutOfRangeException();

            int numBase = 0;
            if (accuracy.ToString().ToLower().Contains("e"))
            {
                string tmp = string.Empty;
                foreach (var item in accuracy.ToString().Split(new[] { '-' })[1])
                {
                    if (char.IsDigit(item) && item != '0')
                        tmp += item;
                }
                numBase = int.Parse(tmp);
                if (numBase > 15) // Max value for precition double in Math.Round(double number, int precition)
                    numBase = 15;
            }
            else if(!accuracy.ToString().ToLower().Contains("e"))
            {
                numBase = accuracy.ToString().Split(new[] { ',' })[1].Length;
            }

            int? result = null;
            for (int i = 1; i < array.Length - 1; i++)
            {
                double leftSum = LeftSum(array, i, numBase);
                double rightSum =RightSum(array, i, numBase);
                if (leftSum == rightSum)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
        /// <summary>
        /// Calculate sum of array elements from 0 index to current index
        /// </summary>
        /// <param name="array"> Initial array </param>
        /// <param name="idx"> Current index </param>
        /// <param name="accuracy"> Accuracy </param>
        /// <returns> Sum of array elements from 0 to idx </returns>
        private static double LeftSum(double[] array, int idx, int numBase)
        {
            double result = 0d;
            for (int i = 0; i < idx; i++)
            {
                result += array[i];
                result = Math.Round(result, numBase);
            }
            return result;
        }
        /// <summary>
        /// Calculate sum of array elements from current index to the end of the array
        /// </summary>
        /// <param name="array"> Initial array </param>
        /// <param name="idx"> Current index </param>
        /// <param name="accuracy"> Accuracy </param>
        /// <returns> Sum of array elements from idx to end of the array </returns>
        private static double RightSum(double[] array, int idx, int numBase)
        {
            double result = 0d;
            for (int i = idx + 1; i < array.Length; i++)
            {
                result += array[i];
                result = Math.Round(result, numBase); // Max 15 for double precition!!!!!!!
            }
            return result;
        }
    }
}
