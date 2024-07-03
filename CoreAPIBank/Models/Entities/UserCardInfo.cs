namespace CoreAPIBank.Models.Entities
{
    public class UserCardInfo : BaseEntity
    {
        //Bankanın orjinal class'ı(domain entity). Bu class dışarıya açılmayacak.

        public string CardUserName { get; set; }
        public string CardNumber { get; set; }
        public string CCV { get; set; }
        public int ExpiryYear { get; set; }
        public int ExpiryMonth { get; set; }
        public decimal CardLimit { get; set; } //Cart'ın limiti
        public decimal Balance { get; set; } //Limitten o ay ne kadar harcanmış..
    }
}
