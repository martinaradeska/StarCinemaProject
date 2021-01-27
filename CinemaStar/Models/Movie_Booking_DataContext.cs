using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CinemaStar.Models
{
    public class Movie_Booking_DataContext :DbContext
    {
        public DbSet<Booking> Booking { get; set; }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<ShowTimeAndDate> ShowTimeAndDate { get; set; }
        public Movie_Booking_DataContext():base("DefaultConnection")
        {
        }
        public static Movie_Booking_DataContext Create()
        {
            return new Movie_Booking_DataContext();
        }
    }
}