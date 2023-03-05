using DIP.Model;

namespace DIP.Factory;

public static class DbProductFactory
{
    public static IDbProduct Create()
    {
        if (string.Equals("sqlserver", AppSettingsReader.GetDbProvider(), StringComparison.InvariantCultureIgnoreCase))
        {
            return new SqlServerProduct();
        }
        else
        {
            return new MongoDbProduct();
        }
    }
}