namespace Assignment2_4;

class Program
{
    public static void Main()
    {
        var rawInput = Console.ReadLine();
        if (rawInput == null)
        {
            throw new FormatException();
        }

        var input = rawInput.Split();
        int height = int.Parse(input[0]), width = int.Parse(input[1]);
        int[,] matrix = new int[height, width];
        for (int i = 0; i < height; i++)
        {
            var line = Console.ReadLine();
            if (line == null)
            {
                throw new FormatException();
            }

            var data = line.Split();
            int len = data.Length;
            if (len != width)
            {
                throw new FormatException();
            }

            for (int j = 0; j < width; j++)
            {
                matrix[i, j] = int.Parse(data[j]);
            }
        }

        var result = IsToeplitz(matrix, height, width);
        Console.WriteLine(
            result ? "The input matrix is a Toeplitz matrix" : "The input matrix is not a Toeplitz matrix");
    }

    public static bool IsToeplitz(int[,] matrix, int height, int width)
    {
        bool[] visited = new bool[height + width - 1];
        int[] value = new int[height + width - 1];
        int CalcPos(int x, int y) => y - x + height - 1;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                int pos = CalcPos(i, j);
                if (!visited[pos])
                {
                    visited[pos] = true;
                    value[pos] = matrix[i, j];
                }
                else
                {
                    if (matrix[i, j] != value[pos])
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}