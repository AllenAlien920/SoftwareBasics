namespace Assignment4_2;

class Program
{
    public static void Main()
    {
        var clock = new AlarmClock();
        clock.Tick += (_, _) => Console.WriteLine("Tick...");
        clock.Alarm += (_, _) => Console.WriteLine("Alarm!");
        clock.AlarmTime = DateTime.Now + TimeSpan.FromSeconds(10);
        clock.Start();
    }
}