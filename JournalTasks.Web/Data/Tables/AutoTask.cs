namespace JournalTasks.Web.Data.Tables;

public class AutoTask {
    public int Id { get; set; }
    public TaskModel Task { get; set; }
    public TaskModel TaskId { get; set; }
    public TimeSpan Period { get; set; }
}