namespace Assignment2_1;

class Program
{
    public static void Main()
    {
        var input = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        int[] ans = new int[256];
        int cnt = 0;
        int p = 2;
        while (p * p <= input)
        {
            if (input % p == 0)
            {
                ans[cnt++] = p;
                input /= p;
            }
            else
            {
                p++;
            }
        }

        if (input != 1)
        {
            ans[cnt++] = input;
        }

        for (int i = 0; i < cnt; i++)
        {
            Console.WriteLine(ans[i]);
        }
    }
}