using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FilmReview.Models
{
    public class Director
    {
        [Key]
        public virtual int DirectorID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public virtual string DirectorFirstName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public virtual string DirectorLastName { get; set; }

        public virtual int FilmId { get; set; }

        public virtual Film Film { get; set; }
    }
}