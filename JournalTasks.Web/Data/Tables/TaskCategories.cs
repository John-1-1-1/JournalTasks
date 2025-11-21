namespace JournalTasks.Web.Data.Tables;

public class TaskCategories {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public ApplicationUser User { get; set; }
    public string  UserId { get; set; }
}