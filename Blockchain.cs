using System;
using System.Security.Cryptography;
using System.Text;

public class Blockchain
{
    // Método para simular o Prova de Trabalho (PoW)
    public static int MineNonce(string transactionData, int difficulty)
    {
        string prefix = new String('0', difficulty); // Define o critério para o hash (por exemplo, "00" para dificuldade 2)
        int nonce = 0;

        while (true)
        {
            string input = transactionData + nonce;
            string hash = ComputeSha256Hash(input);

            if (hash.StartsWith(prefix))
            {
                return nonce;
            }

            nonce++;
        }
    }

    // Função para computar o hash SHA-256 de uma entrada
    private static string ComputeSha256Hash(string input)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Converter byte array para string hexadecimal
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}

