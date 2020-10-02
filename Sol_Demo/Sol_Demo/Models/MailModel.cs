using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.Models
{
    public class MailModel
    {
        public String To { get; set; }

        public String CC { get; set; }

        public String BCC { get; set; }

        public String Subject { get; set; }

        public String Body { get; set; }
    }
}