 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoolEvents.Data.Entities
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int EventId { get; set; }

        public Event Event { get; set; }
    }
}
