namespace Tasky;

public class UserTask
{
    public int Uid { get; private set; }
    public string Text { get; private set; }
    public int? ParentUid { get; private set; }
    
    public List<UserTask> Child { get; set; }

    public UserTask(int uid, string text)
    {
        Uid = uid;
        Text = text;
        ParentUid = null;
    }
    
    public UserTask(int uid, string text, int parentUid)
    {
        Uid = uid;
        Text = text;
        ParentUid = parentUid;
    }
}