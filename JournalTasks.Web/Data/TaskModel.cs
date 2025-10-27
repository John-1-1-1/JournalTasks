namespace JournalTasks.Web.Data;

public class TaskModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Color { get; set; } = "blue-task";
    public ApplicationUser User { get; set; }
}