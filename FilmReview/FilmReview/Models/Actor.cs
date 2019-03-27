using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Actor
    {
        [Key]
        public virtual int ActorID { get; set; }
        //validation for First name, must be over 2 charaters but less than 50
        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [Display(Name = "First Name")]
        public virtual string FirstName { get; set; }
        //validation for last name, must be over 2 characters but less than 100
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public virtual string LastName { get; set; }

        public virtual int FilmId { get; set; }

        public virtual Film Film { get; set; }
    }
}