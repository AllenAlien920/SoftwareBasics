namespace Assignment4_2;

public class AlarmClock
{
    public event EventHandler Tick = null!;
    public event EventHandler Alarm = null!;

    private DateTime CurrentTime { get; set; }
    public DateTime AlarmTime { get; set; }

    public void Start()
    {
        while (true)
        {
            CurrentTime = DateTime.Now;
            Console.WriteLine($"Current Time: {CurrentTime}");
            OnTick();
            if (CurrentTime >= AlarmTime)
            {
                OnAlarm();
                break;
            }
            Thread.Sleep(1000);
        }
    }

    private void OnTick()
    {
        Tick.Invoke(this, EventArgs.Empty);
    }

    private void OnAlarm()
    {
        Alarm.Invoke(this, EventArgs.Empty);
    }
}