using System;
using System.Security.Cryptography;

namespace Noter.Helpers
{
    public static class Aes
    {
        public static byte[] Encrypt(byte[] data, byte[] key)
        {
            if (input.IsNull()) throw new ArgumentNullException("input");
            if (key.IsNull()) throw new ArgumentNullException("key");

            using (var sha256Provider = new SHA256Managed())
                key = sha256Provider.ComputeHash(key);

            using (var aesProvider = new AesCryptoServiceProvider())
            using (var encrypter = aesProvider.CreateEncryptor(key, Config.PrimeNumbers))
                return encrypter.TransformFinalBlock(input, 0, input.Length);
        }

        public static byte[] Decrypt(byte[] input, byte[] key)
        {
            if (input.IsNull()) throw new ArgumentNullException("input");
            if (key.IsNull()) throw new ArgumentNullException("key");

            using (var sha256Provider = new SHA256Managed())
                key = sha256Provider.ComputeHash(key);

            using (var aesProvider = new AesCryptoServiceProvider())
            using (var decrypter = aesProvider.CreateDecryptor(key, Config.PrimeNumbers))
                return decrypter.TransformFinalBlock(input, 0, input.Length);
        }
    }
}
