namespace OOSE.W4.FizzBuzz_TTD.StringCalculator
{
    public class StringCalculatorExercise
    {
        readonly char[] Separators = { ',', '\n' };

        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) return 0;

            var parsedNumbers = numbers.Split(Separators)
                                       .Select(_ => int.Parse(_));

            return parsedNumbers.Sum();
        }
    }
}
