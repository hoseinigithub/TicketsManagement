using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsManagement.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }

        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }

        public Producer Producer { get; set; }
    }

    public enum MovieCategory
    {
        Action = 1,
        Comedy,
        Drama,
        Documentry,
        Cartoon
    }
}