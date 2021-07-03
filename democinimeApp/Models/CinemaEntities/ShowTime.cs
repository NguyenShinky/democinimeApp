using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace democinimeApp.Models.CinemaEntities
{
    public class ShowTime
    {
        public int Id { get; set; }
        public string Time { get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}