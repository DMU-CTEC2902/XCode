using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Film
    {
        [Key]
        public virtual int FilmId { get; set; }

        public virtual int GenreId { get; set; }

        [Required]
        public virtual string FilmName { get; set; }

        public virtual decimal Rating { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public virtual string Description { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual List<Review> Review { get; set; }
    }
}