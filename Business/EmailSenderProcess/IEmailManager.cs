namespace Business.EmailSenderProcess
{
    public interface IEmailManager
    {
        bool SendEmail(EmailMessageModel model);

        Task SendMailAsync(EmailMessageModel model);

        bool SendEmailGmail(EmailMessageModel model);
    }
}
