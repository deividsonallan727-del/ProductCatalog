namespace ProductCatalog.SErvices
{
    public class ProductServices : IProduct
    {
        private readonly IRepositorie<Product> _productRepository;
        private readonly IParser<ProductDTO, Product> _parser;
        
    }
}