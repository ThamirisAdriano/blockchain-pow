public class ProofOfWork
{
    public static int FindNonce(string transactionData, string criteria)
    {
        int nonce = 0;
        while (true)
        {
            string hash = FakeHash(transactionData + nonce.ToString());
            if (hash.StartsWith(criteria))
            {
                return nonce;
            }
            nonce++;
        }
    }

    // Simula uma função de hash. Em uma aplicação real, você usaria uma função de hash criptográfica, como SHA-256.
    public static string FakeHash(string input)
    {
        // Retorna um 'hash' simplificado que simula o resultado de uma função de hash real.
        // Este é apenas um placeholder para o conceito; não use em produção.
        return BitConverter.ToString(new System.Security.Cryptography.SHA256Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(input))).Replace("-", "");
    }
}

