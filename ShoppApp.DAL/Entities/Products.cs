using ShoppApp.DAL.Core;


namespace ShoppApp.DAL.Entities
{
   public class Products : BaseEntity
    {
        public int ProductsId { get; set; }
        public string? ProductName { get; set; }
        public string? SupplierId { get; set; }
        public string? CategoryId { get; set; }
        public string? UnitPrice { get; set; }
        public bool Discontinued { get; set; }
    }
}
