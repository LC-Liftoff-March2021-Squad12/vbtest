using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PracticeManagement.Models
{
    public class CalendarEntry
    {
        [Required]
        public int id { get; set; }
        public string appointmenStartDate { get; set; }
        public string appointmenEndDate { get; set; }

        public string appointmentStarTime { get; set; }
        public string appointmentEndTime { get; set; }
        public DateTime publishDate { get; set; }
       

        [StringLength(100)]
        string title { get; set; }
        [StringLength (100)]
        public string description { get; set; }
        public bool isAllDay { get; set; }
    }
}
