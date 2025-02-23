using System;
public class Base
{

    list<task> yourTasks;
    public static string DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Record task");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Complete task");
        Console.WriteLine("4. Quit");
        Console.WriteLine("What would you like to do? ");
        string input = Console.ReadLine();
        return input;
    }
    
    static void Main()
    {
        do
        {
            input = DisplayMenu();
            if (input == "1")
            {
                Console.WriteLine("Is this a repeatable task? Y/N");
                into = Console.ReadLine();
                if (into == "Y"| into =="y")
                {
                    Console.WriteLine("What is the name of this task?");
                    name = Console.ReadLine();
                    Console.WriteLine("What are the duties of this task?");
                    duty = Console.ReadLine();
                    yourTasks.Add(new repeatable(name,duty);)
                }
                else
                {
                    Console.WriteLine("What is the name of this task?");
                    name = Console.ReadLine();
                    Console.WriteLine("What are the duties of this task?");
                    duty = Console.ReadLine();
                    yourTasks.Add(new normal(name,duty));
                }

            }
            if (input == "2")
            {
                foreach (task in yourTasks)
                {
                    task.display;
                }
                
            }
            if (input == "3")
            {
                Console.WriteLine("Which task did you complete?");
                int input = Int32.Parse(Console.ReadLine());
                yourTasks[input].display()

            }
        } while (input != "4");
    }


}