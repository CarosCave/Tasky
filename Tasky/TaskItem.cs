namespace Tasky;

public class TaskItem
{
    public List<UserTask> tasks;

    public void AddTask(int uid, string text, int? parentUid = null)
    {

        if (parentUid == null)
        {
            tasks.Add(new UserTask(uid, text));
        }
        if (parentUid != null)
        {
           // UserTask result = tasks.Find(task => task.ParentUid == parentUid);
            //Console.WriteLine(result.Uid);
            //Console.WriteLine(tasks.Find(task => task.ParentUid == parentUid));
            //tasks.Find(task => task.ParentUid == parentUid).Child.Add(new UserTask(uid, text));
        }
        
    }
    public TaskItem()
    {
        tasks = new List<UserTask>();
    }
}