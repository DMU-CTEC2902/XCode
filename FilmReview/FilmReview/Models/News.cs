using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class News
    {
        // News properties
        public int NewsID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Subtitle { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Story { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }
    }
}