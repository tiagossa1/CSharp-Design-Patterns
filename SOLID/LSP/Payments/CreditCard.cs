namespace LSP.Payments;

public class CreditCard : BarclaysCard
{
    public override void Validate()
    {
        Console.WriteLine("Validating...");
        Console.WriteLine("OK!");
    }
}