namespace InternetProvider.Domain
{
    public class UserBalance : IEntity<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public decimal Balance { get; set; }
        public bool IsDeleted { get; set; }
    }
}
