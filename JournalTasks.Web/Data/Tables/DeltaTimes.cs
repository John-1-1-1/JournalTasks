namespace JournalTasks.Web.Data.Tables;

public class DeltaTimes {
    public int Id { get; set; }
    public ApplicationUser User { get; set; }
    public int UserId { get; set; }
    public int TaskId { get; set; }
    public TaskModel Task { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsDeleted { get; set; } = false;
    public bool Active { get; set; }
}