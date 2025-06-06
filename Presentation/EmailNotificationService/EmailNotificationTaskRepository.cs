using Microsoft.EntityFrameworkCore;

namespace WorkerService;

public class EmailNotificationTaskRepository
{
    private readonly EmailNotificationContext _context;

    public EmailNotificationTaskRepository(EmailNotificationContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<EmailNotificationTask>> GetUnsentTasksAsync(int limit = 10)
    {
        return await _context.EmailNotificationTasks
            .Where(t => !t.IsSent)
            .OrderBy(t => t.CreatedAt)
            .Take(limit)
            .ToListAsync();
    }

    public async Task AddTaskAsync(EmailNotificationTask task)
    {
        await _context.EmailNotificationTasks.AddAsync(task);
        await _context.SaveChangesAsync();
    }

    public async Task MarkTaskAsSentAsync(EmailNotificationTask task)
    {
        task.IsSent = true;
        task.SentAt = DateTime.UtcNow;
        _context.EmailNotificationTasks.Update(task);
        await _context.SaveChangesAsync();
    }
}
