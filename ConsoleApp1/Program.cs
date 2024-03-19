// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello");
static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Input array cannot be empty or null.");
    }

    int s = 0;
    foreach (int num in numbers)
    {
        s += num;
    }

    return (double)s / numbers.Length;
}
static int FindMaxValue(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Input array cannot be empty or null.");
    }

    int max = numbers[0];
    foreach (int num in numbers)
    {
        if (num > max)
        {
            max = num;
        }
    }

    return max;
}