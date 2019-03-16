using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Genre
    {
        [Key]
        public virtual int GenreId { get; set; }

        [Display(Name = "Genre")]
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }
    }
}