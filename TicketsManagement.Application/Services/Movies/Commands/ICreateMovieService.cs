using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsManagement.Application.Interfaces;
using TicketsManagement.Domain.Entities;

namespace TicketsManagement.Application.Services.Movies.Commands
{
    public interface ICreateMovieService
    {
        void Execute(CreateMovieDto createMovieDto);
    }

    public class CreateMovieService : ICreateMovieService
    {
        private readonly IAppDbContext _context;

        public CreateMovieService(IAppDbContext context)
        {
            _context = context;
        }

        public void Execute(CreateMovieDto createMovieDto)
        {
            Movie movie = new Movie
            {
                Name = createMovieDto.Name,
                Description = createMovieDto.Description,
                Price = createMovieDto.Price,
                ImageURL = createMovieDto.ImageURL,
                StartDate = createMovieDto.StartDate,
                EndDate = createMovieDto.EndDate,
                MovieCategory = createMovieDto.MovieCategory,
                CinemaId = 1,
                ProducerId = 1
            };
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }
    }

    public class CreateMovieDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string? ImageURL { get; set; }
        public IFormFile ImageFile { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }
}