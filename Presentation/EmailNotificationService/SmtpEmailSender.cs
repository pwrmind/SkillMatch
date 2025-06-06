using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace WorkerService;

public class SmtpEmailSender : IEmailSender
{
    private readonly IOptions<EmailSettings> _emailSettings;

    public SmtpEmailSender(IOptions<EmailSettings> emailSettings)
    {
        _emailSettings = emailSettings;
    }

    public async Task SendEmailAsync(string recipient, string subject, string body)
    {
        var message = new MailMessage
        {
            From = new MailAddress(_emailSettings.Value.SenderEmail),
            To = { new MailAddress(recipient) },
            Subject = subject,
            Body = body
        };

        using (var client = new SmtpClient(_emailSettings.Value.SmtpServer, _emailSettings.Value.SmtpPort))
        {
            client.Credentials = new NetworkCredential(_emailSettings.Value.SmtpUsername, _emailSettings.Value.SmtpPassword);
            await client.SendMailAsync(message);
        }
    }
}
