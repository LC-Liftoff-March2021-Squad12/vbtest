using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeManagement.Models
{
    public class Calendar
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int calendarId { get; set; }
        
        [Required]
        public ApplicationUser user { get; set; }
        public List<CalendarEntry> calendarEntries { get; set; }
        
         
    }
}
