using POS.Infrastructure.Commons.Bases.Request;

namespace POS.Infrastructure.Helpers
{
    public static class QueryableHelper
    {
        // v4
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable,
            BasePaginacionRequest basePaginacionRequest)
        {
            return queryable.Skip((basePaginacionRequest.NumPage - 1) * basePaginacionRequest.Records).Take(basePaginacionRequest.Records);
        }
    }
}
