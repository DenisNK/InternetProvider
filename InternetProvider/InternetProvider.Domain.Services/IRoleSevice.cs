using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace InternetProvider.Domain.Services
{
    public interface IRoleSevice
    {
        Role GetRoleByFilter(Expression<Func<Role, bool>> filter, Expression<Func<Role, object>> includes);
        IEnumerable<Role> GetRolesByFilter(Expression<Func<Role, bool>> filter, Expression<Func<Role, object>> includes);
        void UpdateRole(Role role);
        void DeleteRole(int roleId);
    }
}
