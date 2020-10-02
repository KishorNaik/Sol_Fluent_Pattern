using Sol_Demo.Cores.FluentBuilder;
using Sol_Demo.Cores.Fluents;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Fluent
{
    public sealed class MailFluentBuillder : IMailFluentBuilder
    {
        private readonly MailModel mailModel = null;

        public MailFluentBuillder()
        {
            mailModel = new MailModel();
        }

        IToFluent IMailFluent.To(string emailId)
        {
            mailModel.To = emailId;
            return this;
        }

        ICCFluent IToFluent.CC(string emailId)
        {
            mailModel.CC = emailId;
            return this;
        }

        IBccFluent IToFluent.Bcc(string emailId)
        {
            mailModel.BCC = emailId;
            return this;
        }

        IBccFluent ICCFluent.Bcc(string emailId)
        {
            mailModel.BCC = emailId;
            return this;
        }

        ISubjectFluent ICCFluent.Subject(string subject)
        {
            mailModel.Subject = subject;
            return this;
        }

        ISubjectFluent IToFluent.Subject(string subject)
        {
            mailModel.Subject = subject;
            return this;
        }

        ISubjectFluent IBccFluent.Subject(string subject)
        {
            mailModel.Subject = subject;
            return this;
        }

        IBodyFluent ISubjectFluent.Body(string body)
        {
            mailModel.Body = body;
            return this;
        }

        Task<bool> IBodyFluent.Send()
        {
            return Task.Run(() =>
            {
                // Do OPeration.

                Console.WriteLine($"To :{mailModel?.To}");

                if (mailModel?.CC != null)
                {
                    Console.WriteLine($"CC :{mailModel?.CC}");
                }
                if (mailModel?.BCC != null)
                {
                    Console.WriteLine($"BCC :{mailModel?.BCC}");
                }

                Console.WriteLine($"Subject :{mailModel?.Subject}");
                Console.WriteLine($"Body :{mailModel?.Body}");

                Console.WriteLine("Send Mail");
                return true;
            });
        }
    }
}