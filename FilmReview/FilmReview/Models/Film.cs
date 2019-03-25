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
        [StringLength(90, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        [Display(Name = "Film Name")]
        public virtual string FilmName { get; set; }

        public virtual decimal Rating { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.MultilineText)]
        public virtual string Description { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual List<Review> Review { get; set; }
    }
}