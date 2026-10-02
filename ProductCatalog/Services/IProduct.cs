namespace ProductCatalog.SErvices
{
    public interface IProduct
    {
        List<Product> FindAll();
        Product FindById(long id);
        Product Create(Product product);
        Product Update(Product product);
        void Delete(Product product);
    }
}