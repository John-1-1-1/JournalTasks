namespace JournalTasks.Web.Data.Tables;

public class Reminders {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public bool IsReminder { get; set; }
    public TaskModel Task { get; set; }
}