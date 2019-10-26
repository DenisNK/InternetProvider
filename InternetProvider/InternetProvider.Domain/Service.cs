namespace InternetProvider.Domain
{
    public class Service: IEntity<int>
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
