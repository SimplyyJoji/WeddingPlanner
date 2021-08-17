using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class WeddingPlan
    {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int WeddingPlanId { get; set; }
        
        public int UserId { get; set; }
        public int WeddingId { get; set; }

        public User CreatedBy { get; set; }
        public Wedding Wedding { get; set; }
    }
}