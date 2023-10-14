using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsManagement.Common;

namespace TicketsManagement.Application.Services.Actors.Commands.CreateActor
{
    public interface ICreateActorService
    {
        ResultDto Execute(ActorDto model);
    }
}