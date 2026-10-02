namespace ProductCatalog.Data.Converter.Contract
{
    public interface IParser <Origem, Destination>
    {
        Destination Parse(Origem origin);
        List<Destination> Parse(List<Origem> origin);
    }
}