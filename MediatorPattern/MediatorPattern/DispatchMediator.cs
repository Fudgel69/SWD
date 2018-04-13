using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class DispatchMediator : IMediator
    {
        private List<IPolice> policeMen;

        public DispatchMediator()
        {
            policeMen = new List<IPolice>();
        }

        //Adding Policemen
        public void AddPolice(IPolice police)
        {
            policeMen.Add(police);
        }

        //Send Message
        public void SendMessage(string msg, IPolice sender)
        {
            foreach (IPolice police in policeMen)
            {
                if (police != sender)
                {
                    police.ReceiveMessage(msg);
                }

            }
        }
    }
}
