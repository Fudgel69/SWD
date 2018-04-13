using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface IPolice
    {
        void SendMessage(string mgs);
        void ReceiveMessage(string msg);
    }
}
