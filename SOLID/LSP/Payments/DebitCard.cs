namespace LSP.Payments;

public class DebitCard : BarclaysCard
{
    public override void Validate()
    {
        Console.WriteLine("Checking balance...");
        Console.WriteLine("OK!");
    }
}