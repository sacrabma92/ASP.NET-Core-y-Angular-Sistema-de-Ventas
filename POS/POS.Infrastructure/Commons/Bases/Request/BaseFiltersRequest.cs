namespace POS.Infrastructure.Commons.Bases.Request
{
    public class BaseFiltersRequest : BasePaginacionRequest
    {
        public int? NumeroFilter { get; set; } = null;
        public string? TextFilter { get; set; } = null;
        public int? StateFilter { get; set; } = null;
        public string? StartDate { get; set; } = null;
        public string? EndDate { get; set; } = null;
        public bool? Download { get; set; } = false;
    }
}
