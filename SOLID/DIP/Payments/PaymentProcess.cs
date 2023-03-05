using DIP.Factory;
using DIP.Model;

namespace DIP.Payments;

public class PaymentProcess
{
    public void Pay(string id)
    {
        var product = DbProductFactory.Create();
        var productData = product.GetProductById(id);

        Console.WriteLine(productData);
    }
}