using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CinemaStar.Models
{
    public class ShowTimeAndDate
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime ShowDate { get; set; }

        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        public int Duration { get; set; }

        public string ShowTimeDisplay
        {

            get
            {

                return ShowDate.ToShortDateString() + "-" + StartTime.ToShortTimeString();
            }

        }
    }
}