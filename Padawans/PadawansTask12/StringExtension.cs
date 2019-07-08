using System;

namespace PadawansTask12
{
    public static class StringExtension
    {
        public static bool AllCharactersAreUnique(string source)
        {
            //throw new NotImplementedException();
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new ArgumentException();

            for (int i = 0; i < source.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < source.Length; j++)
                {
                    if (source[i] == source[j])
                    {
                        ++count;
                        if (count > 1)
                            return false;
                    }
                }
            }
            return true;
        }
    }
}