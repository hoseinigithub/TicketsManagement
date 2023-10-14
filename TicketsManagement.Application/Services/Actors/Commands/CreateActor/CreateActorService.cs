using TicketsManagement.Application.Interfaces;
using TicketsManagement.Common;
using TicketsManagement.Domain.Entities;

namespace TicketsManagement.Application.Services.Actors.Commands.CreateActor
{
    public class CreateActorService : ICreateActorService
    {
        private readonly IAppDbContext _context;

        public CreateActorService(IAppDbContext context)
        {
            _context = context;
        }
        public ResultDto Execute(ActorDto model)
        {
            Actor actor = new Actor
            {
                FullName = model.FullName,
                Bio = model.Bio,
                ProfilePictureURL = model.ProfilePictureURL
            };

            _context.Actors.Add(actor);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSucces=true,
                Message="با موفقیت ثبت شد",
                StatusCode=200
            };

        }
    }
}