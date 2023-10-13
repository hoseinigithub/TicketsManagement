﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsManagement.Domain.Entities
{
    public class Producer       //تهیه کننده
    {
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }     //بیوگرافی

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}