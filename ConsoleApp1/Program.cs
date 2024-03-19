// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello");
static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Input array cannot be empty or null.");
    }

    int sum = 0;
    foreach (int num in numbers)
    {
        sum += num;
    }

    return (double)sum / numbers.Length;
}