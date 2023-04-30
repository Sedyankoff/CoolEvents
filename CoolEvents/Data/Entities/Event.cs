using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoolEvents.Data.Entities
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [MaxLength(64)]
        public string EventName { get; set; }

        [Required]
        [MaxLength(255)]
        public string EventDescription { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public DateTime EventDate { get; set; }
    }
}
