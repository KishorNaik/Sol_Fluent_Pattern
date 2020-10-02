using Sol_Demo.Cores.Fluents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.Cores.FluentBuilder
{
    public interface IMailFluentBuilder : IMailFluent, IToFluent, ICCFluent, IBccFluent, ISubjectFluent, IBodyFluent
    {
    }
}