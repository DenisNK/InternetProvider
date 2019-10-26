using System;
using System.Collections.Generic;
using InternetProvider.Domain.Entity;
namespace InternetProvider.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public int? Age { get; set; }
        public TypeGender? Gender { get; set; }
        public string Phone { get; set; }
        public DateTime? ExpirationBan { get; set; }
        public bool IsDeleted { get; set; }
        public IList<Role> Roles { get; set; }
        public int TarrifAccountId { get; set; }
        TariffAccount TarrifAccount { get; set; }
     
    }
}
