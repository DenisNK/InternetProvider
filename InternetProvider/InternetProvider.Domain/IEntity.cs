namespace InternetProvider.Domain
{
    public interface IEntity<Type> where Type : struct
    {
        Type Id { get; set; }
        bool IsDeleted { get; set; }
    }
}
