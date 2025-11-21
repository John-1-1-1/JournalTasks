namespace JournalTasks.Web.Data.Tables;

public class TaskPull {
    public int Id {get; set;}
    public string Name {get; set;} = String.Empty;
    public required ApplicationUser User { get; set; }
    public required string Hash { get; set; }
}