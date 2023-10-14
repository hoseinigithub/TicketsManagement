using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketsManagement.Application.Services.Movies.Commands;

namespace EndPoint.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ICreateMovieService _createMovie;

        public MoviesController(ICreateMovieService createMovie)
        {
            _createMovie = createMovie;
        }

        [HttpPost]
        public IActionResult Create([FromForm] CreateMovieDto model)
        {
            string path = Path.Combine(@"F:\Programming\MyProjects\TicketsManagement\EndPoint.Api\pic", model.ImageFile.FileName);
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                model.ImageFile.CopyTo(stream);
            }
            model.ImageURL = path;
            _createMovie.Execute(model);
            return Ok(model);
        }
    }
}