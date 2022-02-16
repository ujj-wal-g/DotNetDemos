﻿using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    public class EmailSender:IEmailSender
    {
        private readonly EmailConfiguration _emailConfiguration;

        public EmailSender(EmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }

        public void SendEmail(Message message)
        {
            var emailMessage = CreateEmailMessage(message);
            Send(emailMessage);

        }
        private MimeMessage CreateEmailMessage(Message message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_emailConfiguration.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject= message.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) {Text= message.Content};
            return emailMessage;
        }
        private void Send(MimeMessage mailmessage)
        {
            using(var client = new SmtpClient())
            {
                try
                {
                    client.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.Port, true);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(_emailConfiguration.UserName, _emailConfiguration.Password);
                    client.Send(mailmessage);
                }
                catch(Exception ex)
                {
                    throw (ex);
                }
                finally
                {
                 client.Disconnect(true);
                    client.Dispose();
                }
            }
        }
    }
}
