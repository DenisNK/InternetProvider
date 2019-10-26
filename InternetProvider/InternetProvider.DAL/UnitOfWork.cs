using InternetProvider.Domain;
using InternetProvider.Domain.Interfaces;

namespace InternetProvider.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InternetProviderContext _context;
        private IEntityProvider<User> _userProvider;
        private IEntityProvider<Role> _roleProvider;
        private IEntityProvider<Tariff> _tariffProvider;
        private IEntityProvider<Service> _serviceProvider;
        private IEntityProvider<UserBalance> _userBalanceProvider;
        private IEntityProvider<UserTariffBalance> _userTariffBalanceProvider;

        public UnitOfWork(InternetProviderContext context)
        {
            _context = context;
        }

        public IEntityProvider<User> Users => _userProvider ?? (_userProvider = new EntityProvider<User>(_context));

        public IEntityProvider<Role> Roles => _roleProvider ?? (_roleProvider = new EntityProvider<Role>(_context));

        public IEntityProvider<Tariff> Tariffs => _tariffProvider ?? (_tariffProvider = new EntityProvider<Tariff>(_context));

        public IEntityProvider<Service> Services => _serviceProvider ?? (_serviceProvider = new EntityProvider<Service>(_context));

        public IEntityProvider<UserBalance> UserBalances => _userBalanceProvider ?? (_userBalanceProvider = new EntityProvider<UserBalance>(_context));

        public IEntityProvider<UserTariffBalance> UserTariffBalances => _userTariffBalanceProvider ?? (_userTariffBalanceProvider = new EntityProvider<UserTariffBalance>(_context));

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
