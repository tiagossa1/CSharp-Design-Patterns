namespace LSP.Payments;

public abstract class BarclaysCard : IPaymentInstrument
{
    public virtual void Validate()
    {
        // Basic validation card.
    }

    public void Collect()
    {
        Console.WriteLine("Payment done!");
    }
}