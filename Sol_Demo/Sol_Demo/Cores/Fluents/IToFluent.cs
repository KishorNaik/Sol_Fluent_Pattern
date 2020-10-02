using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.Cores.Fluents
{
    public interface IToFluent
    {
        ICCFluent CC(string emailId);

        IBccFluent Bcc(string emailId);

        ISubjectFluent Subject(string subject);
    }
}