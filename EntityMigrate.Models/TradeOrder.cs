namespace EntityMigrate.Models
{
    public class TradeOrder
    {
        public long TradeOrderId { get; set; }

        public TradeSubmission TradeSubmission { get; set; }

        public long TradeSubmissionId { get; set; }
    }
}