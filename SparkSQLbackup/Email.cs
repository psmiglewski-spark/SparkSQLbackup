using Limilabs.Client.SMTP;
using Limilabs.Mail;
using Limilabs.Mail.Fluent;
using System;
using System.Collections.Generic;
using System.Text;

namespace SparkSQLbackup
{
    class Email
    {
        private string toAddress;
        private string fromAddress;
        private string subject;
        private string smtpServer;
        private string smtpLogin;
        private string smtpPassword;

        public void SendEmail(string _attachment)
        {
            IMail email = Mail
              .Html(@"Html ")
              .AddAttachment(_attachment).SetFileName("bug.txt")
              .To("psmiglewski@gmail.com")
              .From("kontakt@sparktech.com.pl")
              .Subject("Database backup bugreport")
              .Create();
            using (Smtp smtp = new Smtp())
            {
                smtp.Connect("sparktech.com.pl");  // or ConnectSSL for SSL
                smtp.UseBestLogin("kontakt@sparktech.com.pl", "PIotreck1");
                smtp.SendMessage(email);
                smtp.Close();
            }
        }

    }
}
