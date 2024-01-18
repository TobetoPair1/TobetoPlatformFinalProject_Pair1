using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net.Mail;

namespace Business.EmailSenderProcess
{
    public class EmailManager : IEmailManager
    {
        // IConfiguration, uygulamanın konfigürasyon bilgilerini almak için kullanılır.
        // ILogger, hata durumlarını loglamak için kullanılır.
        private readonly IConfiguration _configuration;
        private readonly ILogger<EmailManager> _logger;

        // Constructor, EmailManager sınıfını başlatırken IConfiguration ve ILogger'ı alır.
        public EmailManager(IConfiguration configuration, ILogger<EmailManager> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        // Email gönderme işlemini gerçekleştiren metot.
        public bool SendEmail(EmailMessageModel model)
        {
            try
            {
                // MailMessage, e-posta gönderme işlemleri için gerekli bilgileri içerir.
                MailMessage message = new MailMessage();
                message.From = new MailAddress("tobeto_pair1@outlook.com");
                message.To.Add(new MailAddress(model.To));
                message.Subject = model.Subject;
                message.Body = model.Body;
                message.IsBodyHtml = true;

                // SmtpClient, SMTP sunucusu üzerinden e-postayı göndermek için kullanılır.
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("tobeto_pair1@outlook.com", "pair1abc");
                client.Port = 587;
                client.Host = "smtp-mail.outlook.com";
                client.EnableSsl = true;

                // E-postayı gönderme işlemi.
                client.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                // Hata durumunda loglama ve işlem başarısız olarak işaretlenir.
                _logger.LogError(ex, "Email sending failed.");
                return false;
            }
        }

        // Async olarak e-posta gönderme işlemini gerçekleştiren metot.
        public async Task SendMailAsync(EmailMessageModel model)
        {
            try
            {
                // Önceki metotla benzer şekilde çalışır, ancak async olarak tasarlanmıştır.
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

                // Async olarak e-postayı gönderme işlemi.
                await client.SendMailAsync(message);
            }
            catch (Exception ex)
            {
                // Hata durumunda loglama.
                _logger.LogError(ex, "Email sending failed.");
            }
        }

        // Gmail üzerinden e-posta gönderme işlemini gerçekleştiren metot.
        public bool SendEmailGmail(EmailMessageModel model)
        {
            try
            {
                // Konfigürasyondan alınan bilgilerle Gmail üzerinden e-posta gönderme işlemi.
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

                // E-postayı gönderme işlemi.
                client.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                // Hata durumunda loglama ve işlem başarısız olarak işaretlenir.
                _logger.LogError(ex, "Email sending failed.");
                return false;
            }
        }
    }
}
