using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Film
    {
        public virtual int FilmId { get; set; }

        public virtual int GenreId { get; set; }

        public virtual string FilmName { get; set; }

        public virtual decimal Rating { get; set; }

        public virtual string Description { get; set; }

        public virtual Genre Genre { get; set; }
        //aa
    }
}