using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Actor
    {
        public virtual int ActorID { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual int FilmId { get; set; }

        public virtual Film Film { get; set; }

    }
}