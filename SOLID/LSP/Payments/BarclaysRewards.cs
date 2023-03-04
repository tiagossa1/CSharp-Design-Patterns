namespace LSP.Payments;

public class BarclaysRewards : IPaymentInstrument
{
    public void Validate()
    {
        Console.WriteLine("Limit OK, rewards OK!");
    }

    public void Collect()
    {
        Console.WriteLine("Payment done.");
        Console.WriteLine("Client received rewards points.");
    }
}