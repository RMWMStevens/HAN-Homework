namespace OOSE.W4.FizzBuzz_TTD.FizzBuzz
{
    public class FizzBuzzExercise
    {
        public string GetLineForNumber(int number) => Fizz(number) + Buzz(number);

        public string Fizz(int number) => number % 3 == 0 ? "Fizz" : string.Empty;

        public string Buzz(int number) => number % 5 == 0 ? "Buzz" : string.Empty;
    }
}
