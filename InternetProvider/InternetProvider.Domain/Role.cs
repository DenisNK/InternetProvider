using System.Collections.Generic;

namespace InternetProvider.Domain
{
    public class Role : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<User> Users { get; set; }
        public bool IsDeleted { get; set; }
    }
}
