using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace InternetProvider.Domain.Services
{
    public interface IUserTariffBalanceService
    {
        UserTariffBalance GetUserTariffBalanceByFilter(Expression<Func<UserTariffBalance, bool>> filter, Expression<Func<UserTariffBalance, object>> includes);
        IEnumerable<UserTariffBalance> GetUserTariffBalancesByFilter(Expression<Func<UserTariffBalance, bool>> filter, Expression<Func<UserTariffBalance, object>> includes);
        void UpdateUserTariffBalance(UserTariffBalance userTariffBalanceId);
        void DeleteUserTariffBalance(int userTariffBalance);
    }
}
