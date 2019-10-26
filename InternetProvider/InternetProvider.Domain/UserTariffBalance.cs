namespace InternetProvider.Domain
{
    public class UserTariffBalance: IEntity<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; } 
        public User User { get; set; }  
        public int TariffId { get; set; }
        public Tariff Tariff { get; set; }
        public bool IsDeleted { get; set; }
    }
}
