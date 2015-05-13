using System;
using System.Security.Cryptography;

namespace Noter.Helpers
{
    public static class Aes
    {
        public static byte[] Encrypt(byte[] input, byte[] password)
        {
            if (input.IsNull()) throw new ArgumentNullException("input");
            if (password.IsNull()) throw new ArgumentNullException("password");

            using (var sha256Provider = new SHA256Managed())
                password = sha256Provider.ComputeHash(password);

            using (var aesProvider = new AesCryptoServiceProvider())
            using (var encrypter = aesProvider.CreateEncryptor(password, Config.PrimeNumbers))
                return encrypter.TransformFinalBlock(input, 0, input.Length);
        }

        public static byte[] Decrypt(byte[] input, byte[] password)
        {
            if (input.IsNull()) throw new ArgumentNullException("input");
            if (password.IsNull()) throw new ArgumentNullException("password");

            using (var sha256Provider = new SHA256Managed())
                password = sha256Provider.ComputeHash(password);

            using (var aesProvider = new AesCryptoServiceProvider())
            using (var decrypter = aesProvider.CreateDecryptor(password, Config.PrimeNumbers))
                return decrypter.TransformFinalBlock(input, 0, input.Length);
        }
    }
}