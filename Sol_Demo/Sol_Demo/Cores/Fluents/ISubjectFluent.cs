using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.Cores.Fluents
{
    public interface ISubjectFluent
    {
        IBodyFluent Body(string body);
    }
}