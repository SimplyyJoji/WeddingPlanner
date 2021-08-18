using System;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Rsvp
    {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int RsvpId { get; set; }
        
        public int UserId { get; set; }
        public User CreatedBy { get; set; }
        public int WeddingId { get; set; }
        public Wedding Wedding { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}