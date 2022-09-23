namespace OOSE.W4.FizzBuzz_TTD.StringCalculator
{
    public class StringCalculatorExercise
    {
        readonly List<char> separators = new() { ',', '\n' };

        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) return 0;

            if (numbers.IndexOf("//") == 0 && numbers.IndexOf("\n") == 3)
            {
                separators.Add(numbers.ElementAt(2));
                numbers = numbers.Remove(0, 4);
            }

            return numbers.Split(separators.ToArray())
                          .Select(_ => int.Parse(_))
                          .Sum();
        }
    }
}
