public class normal : task
{
    public void complete()
    {
        Console.WriteLine("Congrats, you completed this task");
        _condition = "already";
        
    }

}