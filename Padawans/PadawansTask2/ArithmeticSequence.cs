using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            // put your code here
            //throw new NotImplementedException();
            if (count <= 0)
                throw new ArgumentException();

            if ((number >= int.MaxValue) || (number <= int.MinValue))
                throw new OverflowException();

            int result = 0;
            for (int i = 0; i < count; i++)
            {
                result += number + (add * i);
            }
            return result;
        }
    }
}
