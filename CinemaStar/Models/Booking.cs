using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CinemaStar.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int ShowTimeId { get; set; }

        public ShowTimeAndDate ShowTime { get; set; }

        public Movie Movie { get; set; }

        [NotMapped]
        public string BookingReference
        {

            get
            {
                return "MOVIE0" + Id;
            }
        }
    }
}