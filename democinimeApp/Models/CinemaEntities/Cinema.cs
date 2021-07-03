using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace democinimeApp.Models.CinemaEntities
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}