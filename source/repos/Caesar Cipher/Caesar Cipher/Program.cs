using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Enter the text to encrypt:");
            string Secretword = Console.ReadLine();
            char[] secretMessage = Secretword.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char charToEncrypt = secretMessage[i];
                int charposition = Array.IndexOf(alphabet, charToEncrypt);
             
                int newLetterPosition = ((charposition + 3) % alphabet.Length);
                char encryptedCharacter = alphabet[newLetterPosition];
                encryptedMessage[i] = encryptedCharacter;

            }
            string encodedMessage = string.Join("", encryptedMessage);
            Console.WriteLine("The encrypted message is: " + encodedMessage);

        }
    }
}