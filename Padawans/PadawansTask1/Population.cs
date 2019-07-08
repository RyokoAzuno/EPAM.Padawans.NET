using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            // put your code here
            //throw new NotImplementedException();
            if ((currentPopulation <= 0) || (initialPopulation <= 0))
                throw new ArgumentException();
            int totalYears = 0;
            double mult = percent / 100;
            do
            {
                initialPopulation += Convert.ToInt32(mult * initialPopulation) + visitors;
                ++totalYears;
            } while (initialPopulation < currentPopulation);

            return totalYears;
        }
    }
}