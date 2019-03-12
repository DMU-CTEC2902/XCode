using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class News
    {
        // News properties
        public int NewsID { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Story { get; set; }
    }
}