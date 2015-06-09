using System;
using System.Security.Cryptography;

namespace Noter.Helpers
{
    public static class Aes
    {
        public static byte[] Encrypt(byte[] data, byte[] key)
        {
            if (data.IsNull()) throw new ArgumentNullException("data");
            if (key.IsNull()) throw new ArgumentNullException("key");

            key = GetSha256Hash(key);

            using (var provider = new AesCryptoServiceProvider())
            using (var encrypter = provider.CreateEncryptor(key, Config.PrimeNumbers))
                return encrypter.TransformFinalBlock(data, 0, data.Length);
        }

        public static byte[] Decrypt(byte[] data, byte[] key)
        {
            if (data.IsNull()) throw new ArgumentNullException("data");
            if (key.IsNull()) throw new ArgumentNullException("key");

            key = GetSha256Hash(key);

            using (var provider = new AesCryptoServiceProvider())
            using (var decrypter = provider.CreateDecryptor(key, Config.PrimeNumbers))
                return decrypter.TransformFinalBlock(data, 0, data.Length);
        }
        
        private static byte[] GetSha256Hash(byte[] key)
        {
            using (var provider = new SHA256CryptoServiceProvider())
                return provider.ComputeHash(key);
        }
    }
}
