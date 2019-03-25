using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Review
    {
        [Key]
        public virtual int ReviewId { get; set; }

        public virtual int FilmId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public virtual DateTime DateAdded { get; set; }

        [Display(Name = "Review Rating")]
        public virtual decimal ReviewRating { get; set; }

        [Display(Name = "Review")]
        public virtual string Description { get; set; }

        //userid to do
    }
}