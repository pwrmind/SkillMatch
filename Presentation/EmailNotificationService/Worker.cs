namespace WorkerService;

public class EmailNotificationService : BackgroundService
{
    private readonly EmailNotificationTaskRepository _repository;
    private readonly IEmailSender _emailSender;

    public EmailNotificationService(EmailNotificationTaskRepository repository, IEmailSender emailSender)
    {
        _repository = repository;
        _emailSender = emailSender;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var tasks = await _repository.GetUnsentTasksAsync();
            foreach (var task in tasks)
            {
                await _emailSender.SendEmailAsync(task.Recipient, task.Subject, task.Body);
                await _repository.MarkTaskAsSentAsync(task);
            }

            await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
        }
    }
}
