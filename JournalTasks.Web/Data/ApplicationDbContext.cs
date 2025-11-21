using JournalTasks.Web.Data.Tables;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JournalTasks.Web.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options) {
    
    public DbSet<TaskModel> TaskModels { get; set; }
    public DbSet<DeltaTimes> DeltaTimes { get; set; }
     
    public DbSet<TelegramAccount> TelegramAccounts { get; set; }
    public DbSet<Reminders> Reminders { get; set; }
    public DbSet<TaskCategories> TasksCategories { get; set; }
    public DbSet<AutoTask> AutoTasks { get; set; }

}