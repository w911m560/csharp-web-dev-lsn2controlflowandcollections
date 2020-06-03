using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercises
{
    public class EvenSum
    {
        public static int GetEvenSum(List<int> numbers)
        {
            int evenSum = 0;
            foreach (int number in numbers)
            {
                if (number%2 == 0)
                {
                    evenSum += number;
                }
            }
            return evenSum;
        }
    }
}
