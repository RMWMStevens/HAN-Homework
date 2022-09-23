namespace OOSE.W4.FizzBuzz_TTD.StringCalculator
{
    public class StringCalculatorExercise
    {
        readonly List<char> delimiters = new() { ',', '\n' };

        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) return 0;

            if (numbers.StartsWith("//") && numbers.IndexOf('\n') == 3)
            {
                delimiters.Add(numbers.ElementAt(2));
                numbers = numbers.Remove(0, 4);
            }

            var parsedNumbers = numbers.Split(delimiters.ToArray())
                                       .Select(_ => int.Parse(_));

            ThrowExceptionOnNegativeNumbers(parsedNumbers);

            return parsedNumbers.Sum();
        }

        private void ThrowExceptionOnNegativeNumbers(IEnumerable<int> numbers)
        {
            if (numbers.Any(_ => _ < 0))
            {
                throw new ArgumentException($"Negatives not allowed: {string.Join(", ", numbers.Where(_ => _ < 0))}");
            }
        }
    }
}
