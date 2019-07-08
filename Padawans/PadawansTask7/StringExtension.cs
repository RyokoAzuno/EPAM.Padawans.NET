using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            // put your code here
            // throw new NotImplementedException();
            if (array == null)
                throw new ArgumentNullException();

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == null)
                    throw new ArgumentNullException();

                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == null)
                        throw new ArgumentNullException();

                    if (array[min].Length > array[j].Length)
                        min = j;
                }
                Swap(array, i, min);
            }
        }
        /// <summary>
        /// Exchange two elements in an array
        /// </summary>
        /// <param name="arr"> Array </param>
        /// <param name="i"> First index to swap </param>
        /// <param name="j"> Second index to swap </param>
        private static void Swap(string[] arr, int i, int j)
        {
            string tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }
    }
}
