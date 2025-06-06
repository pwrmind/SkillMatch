namespace WorkerService;

public interface IEmailSender
{
    Task SendEmailAsync(string recipient, string subject, string body);
}
