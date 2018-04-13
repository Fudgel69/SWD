using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Chief : IPolice
    {
        private string name;
        private IMediator disMediator;
            
        public Chief(IMediator disMediator, string name)
        {
            this.name = name;
            this.disMediator = disMediator;
        }

        public void SendMessage(string mgs)
        {
            disMediator.SendMessage(mgs, this);
        }

        public void ReceiveMessage(string msg)
        {
            Console.WriteLine($"Chief {name} received the following message: {msg}");
        }
    }
}
