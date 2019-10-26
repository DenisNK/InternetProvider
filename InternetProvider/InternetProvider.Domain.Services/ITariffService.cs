using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace InternetProvider.Domain.Services
{
    public interface ITariffService
    {
        Tariff GetTariffByFilter(Expression<Func<Tariff, bool>> filter, Expression<Func<Tariff, object>> includes);
        IEnumerable<Tariff> GetTariffsByFilter(Expression<Func<Tariff, bool>> filter, Expression<Func<Tariff, object>> includes);
        void UpdateTariff(Tariff tariff);
        void DeleteTariff(int tariffId);
    }
}
