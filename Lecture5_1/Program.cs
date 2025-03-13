namespace Lecture5_1;

internal static class Program
{
    public static void Main()
    {
    }
}

public static class SortUtil
{
    public static void BubbleSort(int[] list)
    {
        int tmp = 0;
        for (int i = 0; i < list.Length - 1; i++)
        {
            bool flag = true;
            for (int j = 0; j < list.Length - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    tmp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = tmp;
                    flag = false;
                }
            }

            if (flag) break;
        }
    }
}