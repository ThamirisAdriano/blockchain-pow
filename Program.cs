class Program
{
    static void Main(string[] args)
    {
        Transaction transaction = new Transaction("Thamiris", "Rafael", 100m);

        // Converter a transação para uma string (em uma aplicação real, isso seria serializado de forma mais segura)
        string transactionData = $"{transaction.Sender}->{transaction.Recipient}: {transaction.Amount}";

        // Encontrar um nonce que satisfaz o critério de hash (por exemplo, começar com "00")
        int nonce = ProofOfWork.FindNonce(transactionData, "00");


        Console.WriteLine($"Nonce encontrado: {nonce}");
    }
}

// class Program
// {
//     static void Main(string[] args)
//     {
//         Transaction transaction = new Transaction("Thamiris", "Rafael", 100m);

//         string transactionData = $"{transaction.Sender}->{transaction.Recipient}: {transaction.Amount}";
//         int difficulty = 2; // Definindo a dificuldade de encontrar o nonce


//         int nonce = Blockchain.MineNonce(transactionData, difficulty);


//         Console.WriteLine($"Nonce encontrado: {nonce}");
//     }
// }

