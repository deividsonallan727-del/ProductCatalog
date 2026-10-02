

namespace ProductCatalog.Model.Entities
{
    public class ProductDTO
    {
       public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public long CategoryId { get; set; }

    }
}
