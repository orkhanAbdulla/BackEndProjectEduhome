using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace EDUHOME.Helpers
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "admin@metanit.com"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.metanit.com", 465, true);
                await client.AuthenticateAsync("testforp119@gmail.com", "1122334455fF$");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
