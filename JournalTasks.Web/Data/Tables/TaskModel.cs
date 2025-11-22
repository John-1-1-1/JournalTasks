namespace JournalTasks.Web.Data.Tables;

public class TaskModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public TaskCategories TaskCategory { get; set; } 
    public int? TaskCategoryId { get; set; } 
    public ApplicationUser User { get; set; }
    
    public string UserId { get; set; }
     

    public bool Active { get; set; }
    public bool AutoTask { get; set; }
    public bool IsTracking { get; set; }

    public List<Reminders> RemindersList { get; set; } = new List<Reminders>();
    public List<DeltaTimes> DeltaTimesList { get; set; } = new List<DeltaTimes>();
}