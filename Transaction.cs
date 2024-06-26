public class Transaction
{
    public string Sender { get; set; }
    public string Recipient { get; set; }
    public decimal Amount { get; set; }

    public Transaction(string sender, string recipient, decimal amount)
    {
        Sender = sender;
        Recipient = recipient;
        Amount = amount;
    }

    public override string ToString()
    {
        return $"Transaction: {Sender} -> {Recipient}, Amount: {Amount}";
    }
}
