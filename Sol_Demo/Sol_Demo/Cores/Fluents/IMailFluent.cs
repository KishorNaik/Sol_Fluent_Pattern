using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.Cores.Fluents
{
    public interface IMailFluent
    {
        IToFluent To(string emailId);
    }
}