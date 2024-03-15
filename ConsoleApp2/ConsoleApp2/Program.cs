// See https://aka.ms/new-console-template for more information

int[] numbersCollection = { 3, 4, 5, 6, 7, 1, 2, 3 };
Console.WriteLine(Calculate(numbersCollection));

static double Calculate(int[] numbers)
{
    return numbers.Average();
}