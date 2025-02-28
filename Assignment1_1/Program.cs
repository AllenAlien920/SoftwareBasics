namespace Assignment1_1;

class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine()!.Split();
        double a = double.Parse(input[0]), b = double.Parse(input[2]);
        string operate = input[1];
        double ans;
        switch (operate)
        {
            case "+":
                ans = a + b;
                break;
            case "-":
                ans = a - b;
                break;
            case "*":
                ans = a * b;
                break;
            case "/":
                if (b == 0)
                {
                    throw new ArithmeticException("Divide by zero");
                }
                ans = a / b;
                break;
            default:
                throw new FormatException("Unsupported operator");
        }

        Console.WriteLine(ans);
    }
}