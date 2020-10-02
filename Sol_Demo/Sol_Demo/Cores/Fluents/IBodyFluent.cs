using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Cores.Fluents
{
    public interface IBodyFluent
    {
        Task<bool> Send();
    }
}