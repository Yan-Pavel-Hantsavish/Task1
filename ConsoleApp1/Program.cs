// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello");
static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Input array cannot be empty or null.");
    }

    int sum = 0;
    foreach (int n in numbers)
    {
        sum += n;
    }

    return (double)sum / numbers.Length;
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