namespace ProductCatalog.Data.Converter.Contract
{
    public class ProductConverter : IParser<ProductDTO, Product>, IParser<Product, ProductDTO>
    {
        public Product Parse(ProductDTO product) 
        {
            return new Product
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
                CategoryId = product.CategoryId
            };
        }
         public List<Product> Parse(List<ProductDTO> productList)
        {
            if(productList == null) return null;
            return productList.Select(item => Parse(item)).ToList();
        }
        public ProductDTO Parse(Product product)
        {
            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
                CategoryId = product.CategoryId};
        }

        public List<ProductDTO> Parse(List<Product> productList)
        {
            if(productList == null) return null;
            return productList.Select(item => Parse(item)).ToList();
        }
    }
}