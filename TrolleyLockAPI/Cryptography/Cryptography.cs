

using System.Security.Cryptography;
using System.Text;
using TrolleyLockAPI.Constants;

namespace TrolleyLockAPI.Cryptography
{
    public class Cryptography
    { 
        public string Encrypt(string encrypt)
        {
            byte[] initializationVector = new byte[16];
            byte[] encryptedString;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(AesKey.Key);
                aes.IV = initializationVector;
                
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(encrypt);
                        }

                        encryptedString = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encryptedString);
        }

        public string Decrypt(string cipher)
        {
            byte[] initializationVector = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipher);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(AesKey.Key);
                aes.IV = initializationVector;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
