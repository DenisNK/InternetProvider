using System;
using System.Collections.Generic;

namespace InternetProvider.Domain
{
    public class Tariff : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal Price { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public bool IsDeleted { get; set; }
        public IEnumerable<UserTariffBalance> UserTariffBalances { get; set; }
    }
}
