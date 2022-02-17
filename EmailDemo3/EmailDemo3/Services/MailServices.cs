using EmailDemo3.model;
using EmailDemo3.Settings;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using MimeKit;

namespace EmailDemo3.Services
{
    public class MailServices : IMailServices
    {
        private readonly MailSettings _mailSetting;

        public MailServices(IOptions<MailSettings> options)
        {
            _mailSetting= options.Value;
        }
        public async Task SendEmailAsync(MailRequest mailRequest)//email,subject and body
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSetting.Mail);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;
            var builder = new BodyBuilder();
            if(mailRequest.Attachements != null)
            {
                byte[] fileBytes;
                foreach(var file in mailRequest.Attachements)
                {
                    if (file.Length > 0)
                    {
                        using (var ms = new MemoryStream())
                        {
                            file.CopyTo(ms);
                            fileBytes = ms.ToArray();

                        }
                        builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
                    }
                }

            }
            builder.HtmlBody = mailRequest.Body;
            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            smtp.Connect(_mailSetting.Host, _mailSetting.Port,SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSetting.Mail,_mailSetting.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
            UserManager


        }
    }
}
