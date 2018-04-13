using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface IMediator
    {
        void AddPolice(IPolice police);
        void SendMessage(string msg, IPolice sender);
    }  
}
