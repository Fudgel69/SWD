using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Officer : IPolice
    {
        private string name;
        private IMediator disMediator;

        public Officer(IMediator disMediator, string name)
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
            Console.WriteLine($"Officer {name} received the following message: {msg}");
        }
    }
}