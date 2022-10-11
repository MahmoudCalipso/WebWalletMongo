namespace WebWallet.Entities
{
    public class WalletProgDetails : BaseEntity
    {
        public string? WalletId { get; set; }
        public string? UserId { get; set; }
        public string? TransactionId { get; set; }
        public string? TransactionName { get; set; }
        public TypeTrac TransactionType { get; set; }
        public int TransactionPoint { get; set; }
        public double TransactionAmount { get; set; }
        public string Note { get; set; }

    }
    public enum TypeTrac
    {
        Gift, Add , Refund 
    }
}
