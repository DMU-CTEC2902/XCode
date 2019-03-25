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

        [Required]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [Display(Name = "Genre")]
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }
    }
}