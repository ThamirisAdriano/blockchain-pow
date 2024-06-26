using System;
using System.Security.Cryptography;
using System.Text;

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
                Console.WriteLine($"Nonce encontrado: {nonce}");
                Console.WriteLine($"Hash resultante: {hash}");
                return nonce;
            }
            nonce++;
        }
    }

    public static string FakeHash(string input)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}
