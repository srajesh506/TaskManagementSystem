using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


namespace TMS.BusinessLogicLayer
{
    public class Operations
    {
        string encryptionKey = Environment.GetEnvironmentVariable("TMSKEY", EnvironmentVariableTarget.Machine);
        public string Encrypt(string encryptString)
        {
            try
            {
                byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);// Convert the string you want to encrypt into bytes
                using (Aes encryptor = Aes.Create())// Create an Aes object for encryption
                {
                    // Create a key derivation function with the encryption key and salt
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                    // Set the encryption key and initialization vector
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())  // Create a memory stream to store the encrypted data
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))// Create a CryptoStream for encryption
                        {
                            cs.Write(clearBytes, 0, clearBytes.Length);// Write the clearBytes (data to be encrypted) into the CryptoStream
                            cs.Close();
                        }
                        encryptString = Convert.ToBase64String(ms.ToArray()); // Convert the encrypted data to a Base64 string
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ErrorBLO01 - Failure in Encryption!! " + "'" + ex.Message + "'");
            }
            return encryptString;
        }

        public string Decrypt(string cipherText)
        {
            try
            {
                cipherText = cipherText.Replace(" ", "+");// Remove any white spaces from the input cipherText
                byte[] cipherBytes = Convert.FromBase64String(cipherText);// Convert the cipherText (Base64 encoded) into bytes
                using (Aes encryptor = Aes.Create())// Create an Aes object for decryption
                {
                    // Create a key derivation function with the encryption key and salt
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                    // Set the decryption key and initialization vector
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())// Create a memory stream to store the decrypted data
                    {
                        // Create a CryptoStream for decryption
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            // Write the cipherBytes (encrypted data) into the CryptoStream
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        // Convert the decrypted bytes to a string
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("ErrorBLO02 - Failure in Decryption!! " + "'" + ex.Message + "'");
            }
            return cipherText;

        }
    }
}