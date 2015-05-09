using System;
using System.Security.Cryptography;

namespace Noter.Helpers
{
    public static class Aes
    {
        public static byte[] Encrypt(byte[] input, byte[] password)
        {
            if (input == null || input.Length == 0)
                throw new ArgumentNullException("input");

            if (password == null || password.Length == 0)
                throw new ArgumentNullException("password");

            using (var md5Provider = new MD5CryptoServiceProvider())
                password = md5Provider.ComputeHash(password);

            using (var aesProvider = new AesCryptoServiceProvider())
            using (var encrypter = aesProvider.CreateEncryptor(password, new byte[16]))
                return encrypter.TransformFinalBlock(input, 0, input.Length);
        }

        public static byte[] Decrypt(byte[] input, byte[] password)
        {
            if (input == null || input.Length == 0)
                throw new ArgumentNullException("input");

            if (password == null || password.Length == 0)
                throw new ArgumentNullException("password");

            using (var md5Provider = new MD5CryptoServiceProvider())
                password = md5Provider.ComputeHash(password);

            using (var aesProvider = new AesCryptoServiceProvider())
            using (var decrypter = aesProvider.CreateDecryptor(password, new byte[16]))
                return decrypter.TransformFinalBlock(input, 0, input.Length);
        }
    }
}