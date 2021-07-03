using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace democinimeApp.Models.CinemaEntities
{
    public class Movie
    {
     
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}