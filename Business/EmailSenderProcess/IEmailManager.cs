namespace Business.EmailSenderProcess;

public interface IEmailManager
{
    bool SendEmail(EmailMessageModel model);

    Task<bool> SendMailAsync(EmailMessageModel model);

    bool SendEmailGmail(EmailMessageModel model);
}