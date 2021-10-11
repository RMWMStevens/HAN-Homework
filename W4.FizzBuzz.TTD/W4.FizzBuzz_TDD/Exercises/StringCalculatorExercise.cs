using System;
using System.Collections.Generic;
using System.Linq;

namespace W4.FizzBuzz_TDD.Exercises
{
    public class StringCalculatorExercise
    {
        public int Add(string numberString)
        {
            // If string is null or whitespace, (early) return 0
            if (string.IsNullOrWhiteSpace(numberString)) { return 0; }

            var numbers = GetNumbers(numberString);
            ThrowExceptionIfNegativesPresent(numbers);
            return numbers.Sum();
        }

        private List<int> GetNumbers(string numberString)
        {
            var numbers = new List<int>();
            var splitNumberStrings = numberString.Split(GetDelimiters(numberString).ToArray());

            // Check for valid numbers
            foreach (var splitNumberString in splitNumberStrings)
            {
                if (int.TryParse(splitNumberString, out var number))
                {
                    numbers.Add(number);
                }
            }
            return numbers;
        }

        private List<char> GetDelimiters(string numberString)
        {
            var delimiters = new List<char>() { ',', '\n' };

            // Check for included delimiter
            if (numberString.StartsWith("//"))
            {
                var delimiter = numberString.Substring(2).Split('\n')[0];
                if (delimiter.Length == 1)
                {
                    delimiters.Add(char.Parse(delimiter));
                }
            }
            return delimiters;
        }

        private void ThrowExceptionIfNegativesPresent(List<int> numbers)
        {
            var negativeNumbers = new List<int>();

            // Check for negatives in list of numbers
            foreach (var number in numbers)
            {
                if (number < 0)
                {
                    negativeNumbers.Add(number);
                }
            }

            // Throw exception if any negative numbers present
            if (negativeNumbers.Count > 0)
            {
                throw new InvalidOperationException(string.Join(", ", negativeNumbers));
            }
        }
    }
}
