namespace DIP.Model;

public class MongoDbProduct : IDbProduct
{
    public string GetProductById(string id)
    {
        return $"MongoDB: showing product with id {id}";
    }
}