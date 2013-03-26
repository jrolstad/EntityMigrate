using System.Collections.Generic;

namespace EntityMigrate.Models
{
    public class TradeSubmission
    {
        public long TradeSubmissionId { get; set; }

        public string Description { get; set; }

        public IEnumerable<TradeOrder> TradeOrders { get; set; } 
    }
}
