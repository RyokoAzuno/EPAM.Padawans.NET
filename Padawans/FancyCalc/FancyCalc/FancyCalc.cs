using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(int a, int b)
        {
            //throw new NotImplementedException();
            return a + b;
        }


        public double Subtract(int a, int b)
        {
            //throw new NotImplementedException();
            return a - b;
        }


        public double Multiply(int a, int b)
        {
            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                throw new ArgumentNullException();
            double result = 0;
            string[] nums = expression.Split(new[] { '+', '-', '*', '/' });
            double leftNum = Convert.ToDouble(nums[0].Trim());
            double rightNum = Convert.ToDouble(nums[1].Trim());

            if ((leftNum == 0 || rightNum == 0) && expression.Contains('/'))
                throw new DivideByZeroException();

            if (expression.Contains('+'))
                result = leftNum + rightNum;
            else if (expression.Contains('-'))
                result = leftNum - rightNum;
            else if (expression.Contains('*'))
                result = leftNum * rightNum;
            else if (expression.Contains('/'))
                result = leftNum / rightNum;

            return Math.Round(result, 3);
        }
    }
}
