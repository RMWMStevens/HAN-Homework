namespace OOSE.W4.FizzBuzz_TTD.StringCalculator
{
    public class StringCalculatorExercise
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) return 0;

            var parsedNumbers = numbers.Split(',')
                                       .Select(_ => int.Parse(_));

            return parsedNumbers.Sum();
        }
    }
}
