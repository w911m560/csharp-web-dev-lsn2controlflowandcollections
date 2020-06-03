using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {2,3,4,5,6,7,8,9,10};
            int evens = EvenSum.GetEvenSum(numbers);
            Console.WriteLine(evens);

            List<string> words = new List<string> {"hello", "press", "hi", "four"};
            string fiveLetterWords = FiveLetterWords.GetFiveLetterWords(words);
            Console.WriteLine(fiveLetterWords);
        }
    }
}
