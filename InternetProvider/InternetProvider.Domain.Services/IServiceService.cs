using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace InternetProvider.Domain.Services
{
    public interface IServiceService
    {
        Service GetServiceByFilter(Expression<Func<Service, bool>> filter, Expression<Func<Service, object>> includes);
        IEnumerable<Service> GetServicesByFilter(Expression<Func<Service, bool>> filter, Expression<Func<Service, object>> includes);
        void UpdateService(Service service);
        void DeleteService(int serviceId);
    }
}
