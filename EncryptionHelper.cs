using System;
using System.Security.Cryptography;
using System.Text;

namespace SafeSharp
{
    public static class EncryptionHelper
    {
        // Method to derive encryption key from the passphrase using PBKDF2
        public static byte[] GetEncryptionKey(string passphrase, byte[] salt)
        {
            // Derive a 256-bit encryption key (32 bytes) from the passphrase and salt
            using (var pbkdf2 = new Rfc2898DeriveBytes(passphrase, salt, 10000)) // 10,000 iterations for security
            {
                return pbkdf2.GetBytes(32); // 256-bit key
            }
        }

        // Encrypt data using passphrase
        public static string Encrypt(string plainText, string passphrase)
        {
            byte[] salt = GenerateSalt(); // A random salt for key derivation
            byte[] key = GetEncryptionKey(passphrase, salt);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = new byte[16]; // AES requires an IV, initialized to zero here

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    byte[] encrypted = msEncrypt.ToArray();
                    // Store the salt along with the encrypted data (salt should be saved along with the encrypted data)
                    byte[] result = new byte[salt.Length + encrypted.Length];
                    Buffer.BlockCopy(salt, 0, result, 0, salt.Length);
                    Buffer.BlockCopy(encrypted, 0, result, salt.Length, encrypted.Length);

                    return Convert.ToBase64String(result);
                }
            }
        }

        // Decrypt data using passphrase
        public static string Decrypt(string encryptedText, string passphrase)
        {
            byte[] encryptedData = Convert.FromBase64String(encryptedText);
            byte[] salt = new byte[16]; // Assuming salt size is 16 bytes
            byte[] cipherText = new byte[encryptedData.Length - salt.Length];

            Buffer.BlockCopy(encryptedData, 0, salt, 0, salt.Length);
            Buffer.BlockCopy(encryptedData, salt.Length, cipherText, 0, cipherText.Length);

            byte[] key = GetEncryptionKey(passphrase, salt);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = new byte[16]; // AES requires an IV, initialized to zero here

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (var msDecrypt = new System.IO.MemoryStream(cipherText))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        // Generate a random salt (16 bytes)
        private static byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16];
                rng.GetBytes(salt);
                return salt;
            }
        }
    }
}
