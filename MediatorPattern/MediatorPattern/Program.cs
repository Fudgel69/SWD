using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {


            //******* Police Department *******
            //create mediator
            IMediator PoliceMediator = new DispatchMediator();

            //create policemen
            IPolice JohnMcclane = new Officer(PoliceMediator, "John");
            IPolice AxelFoley = new Officer(PoliceMediator, "Axel");
            IPolice Riggs = new Officer(PoliceMediator, "Riggs");
            IPolice RoboCop = new Officer(PoliceMediator, "RoboCop");
            IPolice ChiefWiggum = new Chief(PoliceMediator, "Wiggum");

            //Add Policemen to Mediator
            PoliceMediator.AddPolice(JohnMcclane);
            PoliceMediator.AddPolice(AxelFoley);
            PoliceMediator.AddPolice(Riggs);
            PoliceMediator.AddPolice(RoboCop);
            PoliceMediator.AddPolice(ChiefWiggum);


            ChiefWiggum.SendMessage("Calling all Chiefs and Officers, for Backup!");
            JohnMcclane.SendMessage("Yippee-ki-yay, motherfucker!");

            /*
            //******* Fire Department *******
            //create mediator
            IMediator FireMediator = new DispatchMediator();

            //cleate Firemen
            IPolice Fireman1 = new Officer(FireMediator, "F1");
            IPolice Fireman2 = new Officer(FireMediator, "F2");
            IPolice Fireman3 = new Officer(FireMediator, "F3");

            //Add Firemen to Mediator
            FireMediator.AddPolice(Fireman1);
            FireMediator.AddPolice(Fireman2);
            FireMediator.AddPolice(Fireman3);
            

            Fireman3.SendMessage("Hello fellow Firemen, let's party tonight");
            */
        }
    }
}
