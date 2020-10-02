using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.Cores.Fluents
{
    public interface ICCFluent
    {
        IBccFluent Bcc(string emailId);

        ISubjectFluent Subject(string subject);
    }
}