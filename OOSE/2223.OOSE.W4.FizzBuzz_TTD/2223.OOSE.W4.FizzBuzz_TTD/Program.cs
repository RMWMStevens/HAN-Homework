using OOSE.W4.FizzBuzz_TTD.FizzBuzz;

var fizzBuzz = new FizzBuzzExercise();

for (int number = 1; number <= 100; number++)
{
    Console.WriteLine($"{number}: {fizzBuzz.GetLineForNumber(number)}");
}