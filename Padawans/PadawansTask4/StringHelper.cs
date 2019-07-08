using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            // put your code here
            //throw new NotImplementedException();
            if (str == null)
                throw new ArgumentNullException();
            if (str == "")
                throw new ArgumentException();
            int result = 0;
            foreach (var item in str)
            {
                if ("aeiou".IndexOf(item) != -1)
                    ++result;
            }
            return result;
        }
    }
}
