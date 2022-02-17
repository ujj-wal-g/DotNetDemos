using EmailDemo3.model;

namespace EmailDemo3.Services
{
    public interface IMailServices
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
