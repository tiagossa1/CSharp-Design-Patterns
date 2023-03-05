namespace DIP.Model;

public class SqlServerProduct : IDbProduct
{
    public string GetProductById(string id)
    {
        return $"SqlServer: showing product with id {id}";
    }
}