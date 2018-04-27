using System;

namespace Geek.Infrastructrue.Mail
{
    public class MailException : Exception
    {
        public MailException(string exception) : base(exception)
        {

        }
    }
}