namespace Assignment2_2;

class Program
{
    public static void Main()
    {
        var rawInput = Console.ReadLine();
        if (rawInput == null)
        {
            throw new FormatException("Please Enter an integer array");
        }

        var input = rawInput.Split();
        int len = input.Length;
        int[] data = new int[len];
        var max = int.MinValue;
        var min = int.MaxValue;
        int sum = 0;
        for (int i = 0; i < len; i++)
        {
            max = Math.Max(max, data[i]);
            min = Math.Min(min, data[i]);
            sum += data[i];
        }

        var avg = (double)sum / len;
        Console.WriteLine("Max value: " + max);
        Console.WriteLine("Min value: " + min);
        Console.WriteLine("Average value: " + avg);
        Console.WriteLine("Sum: " + sum);
    }
}