using System.IO; 

public abstract class Task
{
    public string _name;
    public string _duties;
    public string _condition;

    public void display()
    {
        console.WriteLine("Your requirements for this task are" + _duties);
        console.WriteLine("Your task is " + _condition +" complete");
    }

    public Task(string name, string duty)
    {
        _name = name;
        _duties = duty;
        _condition = "not";
    }

}