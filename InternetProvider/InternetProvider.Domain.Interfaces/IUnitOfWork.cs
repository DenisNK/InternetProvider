namespace InternetProvider.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IEntityProvider<User> Users { get; }
        IEntityProvider<Role> Roles { get; }
        IEntityProvider<Tariff> Tariffs { get; }
        IEntityProvider<Service> Services { get; }
        IEntityProvider<UserBalance> UserBalances { get; }
        IEntityProvider<UserTariffBalance> UserTariffBalances { get; }
        void Commit();
    }
}
