using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Review
    {
        public virtual int ReviewId { get; set; }
        public virtual int FilmId { get; set; }
        public virtual DateTime DateAdded { get; set; }
        public virtual decimal ReviewRating { get; set; }
        public virtual string Description { get; set; }
        //userid to do
    }
}