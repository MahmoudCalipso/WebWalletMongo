namespace WebWallet.Entities
{
    public class WalletPrograms : BaseEntity
    {
        public string UserId { get; set; }
        public int CurrentPointBalance { get; set; }
        public double TotalSpentAmount { get; set; }
    }

}
