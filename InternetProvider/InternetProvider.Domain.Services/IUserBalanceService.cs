using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace InternetProvider.Domain.Services
{
    public interface IUserBalanceService
    {
        UserBalance GetUserBalanceByFilter(Expression<Func<UserBalance, bool>> filter, Expression<Func<UserBalance, object>> includes);
        IEnumerable<UserBalance> GetUserBalancesByFilter(Expression<Func<UserBalance, bool>> filter, Expression<Func<UserBalance, object>> includes);
        void UpdateUserBalance(UserBalance userBalance);
        void DeleteUserBalance(int userBalanceId);
    }
}
