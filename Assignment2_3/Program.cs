namespace Assignment2_3;

class Program
{
    public static void Main()
    {
        int[] prime = new int[101];
        int[] minp = new int[101];
        int total = 0;
        for (int i = 2; i <= 100; i++)
        {
            if (minp[i] == 0)
            {
                minp[i] = i;
                prime[total++] = i;
            }

            for (int j = 0; j < total; j++)
            {
                int p = prime[j];
                if (i * p > 100) break;
                minp[i * p] = p;
                if (p == minp[i]) break;
            }
        }

        for (int i = 0; i < total; i++)
        {
            Console.Write(prime[i] + " ");
        }

        Console.WriteLine();
    }
}