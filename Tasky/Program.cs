using System.Diagnostics.SymbolStore;
using System.Security.AccessControl;
using Tasky;



public class Program
{
    public static void Main(string[] args)
    {

        TaskItem item = new TaskItem();
        
        
        
        item.AddTask(0,"Dies");
        item.AddTask(1,"Das");
        item.AddTask(2,"Welches");
        // item.AddTask(3,"dies",0);
        // item.AddTask(4, "das",1);
        // item.AddTask(5,"welches",2);

        var results = item.tasks.Find(task => task.Uid == 2);

        Console.WriteLine(results.Uid);
        Console.WriteLine(results.Text);
        results.Child.Add(new UserTask(0, "jenes"));
        
        // item.tasks.Add(new UserTask(0, "Dies"));
        // tasks.Add(new UserTask(1, "Das"));
        // tasks.Add(new UserTask(2, "Welches"));
        //
        // tasks.Add(new UserTask(3, "Dies",0));
        // tasks.Add(new UserTask(4, "Das",0));
        // tasks.Add(new UserTask(5, "Welches",1));

        //Console.WriteLine(item.tasks.Count);

        for (int i = 0; i < item.tasks.Count; i++)
        {
            Console.WriteLine(i + " " + item.tasks[i].Text + " " + item.tasks[i].ParentUid);
        
        }

        List<UserTask> result = new List<UserTask>(item.tasks.FindAll(
            task => task.ParentUid == 0));
    }
    
    
   
}

