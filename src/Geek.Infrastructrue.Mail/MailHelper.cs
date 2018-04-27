using MailKit.Net.Smtp;
using MimeKit;

namespace Geek.Infrastructrue.Mail
{
    public class MailHelper
    {
        SmtpClient _smtpclient;
        MailConfig _config;
        public MailHelper(MailConfig config)
        {
            _config = config;
            _smtpclient = new SmtpClient();
            _smtpclient.Connect(config.SmtpHost, config.SmtpPort, config.UseSsl);
            _smtpclient.Authenticate(config.UserName, config.Password);
            _smtpclient.ServerCertificateValidationCallback = (s, c, h, e) => true;
        }

        public void Send(string subject, string body, string[] mailAddresses)
        {
            if (mailAddresses == null || mailAddresses.Length == 0)
            {
                throw new MailException("收件邮箱地址不能为空！");
            }

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("极客云搜", _config.UserName));
            foreach (var mail in mailAddresses)
            {
                message.To.Add(new MailboxAddress(mail));
            }
            message.Subject = subject;
            message.Body = new TextPart("plain") { Text = body };
            _smtpclient.Send(message);
        }
    }
}