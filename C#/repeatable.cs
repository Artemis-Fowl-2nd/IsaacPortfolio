public class repeatable : task
{
    int : times;

    public void complete()
    {
        Console.WriteLine("Congrats, you completed this task" + times + "times");
        times = times +1;
        _condition = "already";
    }

    public repeatable(string name, string duty) : base(name, duty)
    {
        _timesCompleted = 0;
    }
}