// See https://aka.ms/new-console-template for more information

int[] numbers = { 3, 4, 5, 6, 7, 1, 2, 3 };
Console.WriteLine(Calculate(numbers));

static double Calculate(int[] numbers)
{
    return numbers.Average();
}