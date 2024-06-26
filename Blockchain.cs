using System;
using System.Security.Cryptography;
using System.Text;

public class Blockchain
{
    public static int MineNonce(string transactionData, int difficulty)
    {
        string prefix = new String('0', difficulty);
        int nonce = 0;

        while (true)
        {
            string input = transactionData + nonce;
            string hash = ComputeSha256Hash(input);

            if (hash.StartsWith(prefix))
            {
                Console.WriteLine($"Nonce encontrado: {nonce}");
                Console.WriteLine($"Hash resultante: {hash}");
                return nonce;
            }

            nonce++;
        }
    }

    private static string ComputeSha256Hash(string input)
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
