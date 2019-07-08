using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            // put your code here
            //throw new NotImplementedException();
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new ArgumentException();

            string result = "Yes";
            for (int i = 0, j = source.Length - 1; i <= j; i++, j--)
            {
                if(source[i] != source[j])
                {
                    result = "No";
                    break;
                }
            }
            return result;
        }
    }
}
