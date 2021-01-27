using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CinemaStar.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal TicketPrice { get; set; }

        [Required]
        public string image_path { get; set; }

        [Required]
        public string rating { get; set; }

    }
}