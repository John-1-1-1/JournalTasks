namespace JournalTasks.Web.Data.Tables;

public class Colors {
    public int Id { get; set; }
    public string Color { get; set; }
    public TaskPull Pull { get; set; }
    public TaskPull PullId { get; set; }
    public ApplicationUser Creator { get; set; }
    public ApplicationUser CreatorId { get; set; }
}