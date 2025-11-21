namespace JournalTasks.Web.Data.Tables;

public class UsersGroup {
    public int Id {get; set;}
    public TaskPull TaskPull { get; set; }
    public ApplicationUser User { get; set; }
    
    public int TaskPullId { get; set; }
    public int UserId { get; set; }
}