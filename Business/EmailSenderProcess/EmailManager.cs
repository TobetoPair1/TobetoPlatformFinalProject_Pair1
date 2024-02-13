using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net.Mail;

namespace Business.EmailSenderProcess;

public class EmailManager : IEmailManager
{
    
    private readonly IConfiguration _configuration;
    private readonly ILogger<EmailManager> _logger;

    
    public EmailManager(IConfiguration configuration, ILogger<EmailManager> logger)
    {
        _configuration = configuration;
        _logger = logger;
    }

    
    public bool SendEmail(EmailMessageModel model)
    {
        try
        {
            
            MailMessage message = new MailMessage();
            message.From = new MailAddress("tobeto_pair1@outlook.com");
            message.To.Add(new MailAddress(model.To));
            message.Subject = model.Subject;
            message.Body = model.Body;
            message.IsBodyHtml = true;

            
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("tobeto_pair1@outlook.com", "pair1abc");
            client.Port = 587;
            client.Host = "smtp-mail.outlook.com";
            client.EnableSsl = true;

            
            client.Send(message);
            return true;
        }
        catch (Exception ex)
        {
            
            _logger.LogError(ex, "Email sending failed.");
            return false;
        }
    }

    
    public async Task<bool> SendMailAsync(EmailMessageModel model)
    {
        try
        {
            
            MailMessage message = new MailMessage();
            message.From = new MailAddress("tobeto_pair1@outlook.com");
            message.To.Add(new MailAddress(model.To));
            message.Subject = model.Subject;
            message.Body = model.Body;
            message.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("tobeto_pair1@outlook.com", "pair1abc");
            client.Port = 587;
            client.Host = "smtp-mail.outlook.com";
            client.EnableSsl = true;

            
            await client.SendMailAsync(message);
            return true;
        }
        catch (Exception ex)
        {
            
            _logger.LogError(ex, "Email sending failed.");
            return false;
        }
    }

    
    public bool SendEmailGmail(EmailMessageModel model)
    {
        try
        {
            
            MailMessage message = new MailMessage();
            message.From = new MailAddress(_configuration.GetSection("SystemEmailOptions:Email").Value?.ToString());
            message.To.Add(new MailAddress(model.To));
            message.Subject = model.Subject;
            message.Body = model.Body;
            message.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(_configuration.GetSection("SystemEmailOptions:Email").Value?.ToString(), _configuration.GetSection("SystemEmailOptions:Token").Value?.ToString());
            client.Port = Convert.ToInt32(_configuration.GetSection("SystemEmailOptions:SmtpPort").Value);
            client.Host = _configuration.GetSection("SystemEmailOptions:SmtpHost").Value?.ToString();
            client.EnableSsl = true;

            
            client.Send(message);
            return true;
        }
        catch (Exception ex)
        {
            
            _logger.LogError(ex, "Email sending failed.");
            return false;
        }
    }
}