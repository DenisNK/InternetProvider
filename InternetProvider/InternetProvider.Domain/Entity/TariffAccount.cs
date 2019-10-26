using System.Collections.Generic;

namespace InternetProvider.Domain
{
    public class TariffAccount : IEntity<int>
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
