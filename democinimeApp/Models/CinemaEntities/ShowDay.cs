using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace democinimeApp.Models.CinemaEntities
{
    public class ShowDay
    {
        public int Id { get; set; }
        public DateTime Day{ get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}