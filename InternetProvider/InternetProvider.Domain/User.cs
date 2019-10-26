using System;
using System.Collections.Generic;

namespace InternetProvider.Domain
{
    public class User : IEntity<int>
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; }
        public DateTime? ExpirationBan { get; set; }
        public bool IsDeleted { get; set; }
        public int UserBalanceId { get; set; }
        public UserBalance UserBalance { get; set; }
        public IList<Role> Roles { get; set; }
        public IList<Service> Service { get; set; }
        public IList<UserTariffBalance> UserTariffBalances { get; set; }
    }
}
