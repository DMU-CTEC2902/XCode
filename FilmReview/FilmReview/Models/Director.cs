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

        public virtual string DirectorFirstName { get; set; }

        public virtual string DirectorLastName { get; set; }

        public virtual int ActorID { get; set; }

        public virtual int FilmId { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual Film Film { get; set; }
    }
}