using JournalTasks.Web.Data;
using JournalTasks.Web.Data.Tables;
using Microsoft.EntityFrameworkCore;

namespace JournalTasks.Web.Services.DataModels;

public class TaskModelHelper {
    

    public static IList<TaskModel> GetTaskByUser(IDbContextFactory<ApplicationDbContext>  dbContextFactory, string? userId) {
        var context = dbContextFactory.CreateDbContext();
        return context.TaskModels
            .Include(t => t.TaskCategory)
            .Where(t => t.User.Id == userId).ToList();
    }
    
    public static void CreateTask(IDbContextFactory<ApplicationDbContext> dbContextFactory,  TaskModel taskModel) {
        var context = dbContextFactory.CreateDbContext();
        context.TaskModels.Add(taskModel);
        context.SaveChanges();
    }

    public static void UpdateTask(IDbContextFactory<ApplicationDbContext> dbContextFactory, TaskModel taskModel) {
        var context = dbContextFactory.CreateDbContext();
        context.TaskModels.Update(taskModel);
        context.SaveChanges();
    }
}