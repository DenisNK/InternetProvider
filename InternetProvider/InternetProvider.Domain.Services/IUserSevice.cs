using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace InternetProvider.Domain.Services
{
    public interface IUserSevice
    {
        User GetUserBalanceByFilter(Expression<Func<User, bool>> filter, Expression<Func<User, object>> includes);
        IEnumerable<User> GetUserBalancesByFilter(Expression<Func<User, bool>> filter, Expression<Func<User, object>> includes);
        void UpdateUserBalance(User user);
        void DeleteUserBalance(int userId);
    }
}
