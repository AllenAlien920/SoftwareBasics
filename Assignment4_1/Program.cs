namespace Assignment4_1;

class Program
{
    public static void Main()
    {
        var list = new GenericList<int>();
        for (var i = 0; i < 10; i++)
        {
            list.Add(i);
        }

        list.ForEach(Console.WriteLine);

        var max = int.MinValue;
        list.ForEach(x => max = int.Max(max, x));
        var min = int.MaxValue;
        list.ForEach(x => min = int.Min(min, x));
        var sum = 0;
        list.ForEach(x => sum += x);
        Console.WriteLine($"Max: {max} Min: {min} Sum: {sum}");
    }
}