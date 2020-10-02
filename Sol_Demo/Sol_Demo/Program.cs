using Sol_Demo.Cores.FluentBuilder;
using Sol_Demo.Fluent;
using System;
using System.Threading.Tasks;

namespace Sol_Demo
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IMailFluentBuilder mailFluentBuilder = new MailFluentBuillder();
            // Basic fluent flow
            var flag =
                 await
                 mailFluentBuilder
                 .To("kishor.naik011.net@gmail.com")
                 .Subject("Hello Fluent")
                 .Body("This is a Fluent Design Pattern Example with fluent rule. I hope you enjoyed.")
                 .Send();

            //CC Rule
            mailFluentBuilder = new MailFluentBuillder();
            flag =
                  await
                  mailFluentBuilder
                  .To("kishor.naik011.net@gmail.com")
                  .CC("eshaan@gmail.com")
                  .Subject("Hello Fluent")
                  .Body("This is a Fluent Design Pattern example with fluent rule. I hope you enjoyed")
                  .Send();

            // BCC Rule
            mailFluentBuilder = new MailFluentBuillder();
            flag =
                  await
                  mailFluentBuilder
                  .To("kishor.naik011.net@gmail.com")
                  .Bcc("eshaan@gmail.com")
                  .Subject("Hello Fluent")
                  .Body("This is a Fluent Design Pattern example with fluent rule. I hope you enjoyed")
                  .Send();

            // CC & BCC Rule
            mailFluentBuilder = new MailFluentBuillder();
            flag =
                  await
                  mailFluentBuilder
                  .To("kishor.naik011.net@gmail.com")
                  .CC("mahesh@gmail.com")
                  .Bcc("eshaan@gmail.com")
                  .Subject("Hello Fluent")
                  .Body("This is a Fluent Design Pattern example with fluent rule. I hope you enjoyed")
                  .Send();
        }
    }
}