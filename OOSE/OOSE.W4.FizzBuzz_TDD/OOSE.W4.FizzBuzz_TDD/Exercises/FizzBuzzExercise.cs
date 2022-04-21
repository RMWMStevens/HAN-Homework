using System;

namespace OOSE.W4.FizzBuzz_TDD.Exercises
{
    public class FizzBuzzExercise
    {
        public void Run()
        {
            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{i}: {FizzBuzz(i)}");
            }
        }

        public string Fizz(int number) => number % 3 == 0 ? "Fizz" : string.Empty;

        public string Buzz(int number) => number % 5 == 0 ? "Buzz" : string.Empty;

        public string FizzBuzz(int number) => Fizz(number) + Buzz(number);
    }
}
