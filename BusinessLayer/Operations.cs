using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using TMS.BusinessLogicLayer;

namespace TMS.BusinessLogicLayer
{
    public class Operations
    {
        public string Encrypt(string encryptString)
        {
            try
            {
                string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(clearBytes, 0, clearBytes.Length);
                            cs.Close();
                        }
                        encryptString = Convert.ToBase64String(ms.ToArray());
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
                string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                cipherText = cipherText.Replace(" ", "+");
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
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

        public int ValidateEmailId(string emailId)
        {
            try
            {
                /*Regular Expressions for email id*/
                System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (emailId.Length > 0)
                {
                    if (!rEMail.IsMatch(emailId))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
                return 2;
            }
            catch(Exception ex)
            {
                throw new Exception("ErrorBLO03 - Failure in Email Validation!! " + "'" + ex.Message + "'");
            }
            
        }
    }
}