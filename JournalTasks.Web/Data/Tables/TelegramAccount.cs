namespace JournalTasks.Web.Data.Tables;

public class TelegramAccount {
    public int Id { get; set; }
    public string TelegramId { get; set; }
    public ApplicationUser User { get; set; }
}