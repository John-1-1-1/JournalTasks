namespace JournalTasks.Web.Services;

public interface IUserService
{
    Task<string?> GetUserIdAsync();
}