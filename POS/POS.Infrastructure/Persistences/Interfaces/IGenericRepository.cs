using POS.Infrastructure.Commons.Bases;
using POS.Infrastructure.Helpers;
using System.Linq.Dynamic.Core;

namespace POS.Infrastructure.Persistences.Interfaces
{
    internal interface IGenericRepository<T> where T : class
    {
        protected IQueryable<TDTO> Ordering<TDTO>(BasePaginacionRequest request, IQueryable<TDTO> queryable, bool pagination = false) where TDTO : class
        {
            IQueryable<TDTO> queryDto = request.Order == "desc" ? queryable.OrderBy($" {request.Sort} descending") : queryable.OrderBy($"{request.Sort} ascending");

            if (pagination) queryDto = queryDto.Paginate(request);

            return queryDto;
        }
    }
}
