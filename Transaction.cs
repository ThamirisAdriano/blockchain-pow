public class Transaction
{
    public string Sender { get; set; } // Endereço da carteira do remetente
    public string Recipient { get; set; } // Endereço da carteira do destinatário
    public decimal Amount { get; set; } // Quantidade a ser transferida

    public Transaction(string sender, string recipient, decimal amount)
    {
        Sender = sender;
        Recipient = recipient;
        Amount = amount;
    }
}
