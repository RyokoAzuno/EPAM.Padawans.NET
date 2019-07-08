using System;

namespace PadawansTask10
{
    public static class NullableTypeExtensions
    {
        public static bool IsNull(this object variable)
        {
            // put your code here
            // throw new NotImplementedException();
            bool result = false;

            if (variable == null)
                result = true;

            return result;
        }
    }
}
