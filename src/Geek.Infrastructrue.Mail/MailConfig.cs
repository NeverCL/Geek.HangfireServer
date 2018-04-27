using Geek.Infrastructrue.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Geek.Infrastructrue.Mail
{
    public class MailConfig
    {
        public string SmtpHost { get; set; } = "smtp.mxhichina.com";
        public int SmtpPort { get; set; } = 465;
        public bool UseSsl { get; set; } = true;
        public string UserName { get; set; }
        public string Password { get; set; }
        public static MailConfig GetDefault()
        {
            return IocManager.GetService<IConfiguration>().GetSection(MailConsts.ConfigName).Get<MailConfig>();
        }
    }
}