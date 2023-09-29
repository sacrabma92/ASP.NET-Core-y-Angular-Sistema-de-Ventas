namespace POS.Infrastructure.Commons.Bases.Response
{
    // Ayuda a devolver de la BD los registros
    public class BaseEntityResponse<T>
    {
        public int? TotalRecords { get; set; }
        public List<T>? Items { get; set; }
    }
}
