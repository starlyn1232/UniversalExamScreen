using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace UniversalExamScreen
{
    internal static class EncryptManager
    {
        //Majority of code from:
        //https://foxlearn.com/windows-forms/how-to-encrypt-and-decrypt-files-using-aes-encryption-algorithm-in-csharp-396.html

        //Declare the ZeroMemory method to remove the key from memory after use for security.

        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        internal static extern bool ZeroMemory(IntPtr Destination, int Length);

        //Create the GenerateSalt method to generate the salt that will be used to encrypt your file.

        private static byte[] GenerateSalt()
        {
            byte[] data = new byte[64];
            using (var rgnCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rgnCryptoServiceProvider.GetBytes(data);
            }

            return data;
        }

        //Extra protection hash

        private static string extraEncrypt = Convert.ToHexString((new SHA1CryptoServiceProvider().ComputeHash
                    (Encoding.ASCII.GetBytes(String.Format("UniversalExamScreenProtectionByStarlyn1232")))));

        /// <summary>
        /// Used to encrypt our data :)
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        internal static bool EncryptFile(string filePath, string EncryptKey)
        {
            try
            {
                string tempFile = @"C:\ProgramData\"
                    + filePath.Substring(filePath.LastIndexOf("\\") + 1);

                byte[] salt = GenerateSalt();
                byte[] passwords = Encoding.UTF8.GetBytes(EncryptKey + "UniversalExamScreen" + extraEncrypt);
                RijndaelManaged AES = new RijndaelManaged();
                AES.KeySize = 256;//aes 512 bit encryption c#
                AES.BlockSize = 128;//aes 128 bit encryption c#
                AES.Padding = PaddingMode.PKCS7;
                var key = new Rfc2898DeriveBytes(passwords, salt, 75000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Mode = CipherMode.CFB;
                using (FileStream fsCrypt = new FileStream(tempFile, FileMode.Create))
                {
                    fsCrypt.Write(salt, 0, salt.Length);
                    using (CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (FileStream fsIn = new FileStream(filePath, FileMode.Open))
                        {
                            byte[] buffer = new byte[1048576];
                            int read;
                            while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                cs.Write(buffer, 0, read);
                            }
                        }
                    }
                }

                //After decrypt, let's replace the file

                File.Delete(filePath);
                File.Move(tempFile, filePath);

                return true;
            }

            catch(Exception ex)
            {
                //MessageBox.Show("Encrypt failed:\n\n" + ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Used to decrypt out data :)
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="DecryptKey"></param>
        /// <returns></returns>
        internal static bool DecryptFile(string filePath, string DecryptKey)
        {
            try
            {
                string tempFile = @"C:\ProgramData\"
                    + filePath.Substring(filePath.LastIndexOf("\\") + 1);
                
                byte[] passwords = Encoding.UTF8.GetBytes(DecryptKey + "UniversalExamScreen" + extraEncrypt);
                byte[] salt = new byte[64];
                using (FileStream fsCrypt = new FileStream(filePath, FileMode.Open))
                {
                    fsCrypt.Read(salt, 0, salt.Length);
                    RijndaelManaged AES = new RijndaelManaged();
                    AES.KeySize = 256;//aes 512 bit encryption c#
                    AES.BlockSize = 128;//aes 128 bit encryption c#
                    var key = new Rfc2898DeriveBytes(passwords, salt, 75000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);
                    AES.Padding = PaddingMode.PKCS7;
                    AES.Mode = CipherMode.CFB;
                    using (CryptoStream cryptoStream = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (FileStream fsOut = new FileStream(tempFile, FileMode.Create))
                        {
                            int read;
                            byte[] buffer = new byte[1048576];
                            while ((read = cryptoStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                fsOut.Write(buffer, 0, read);
                            }
                        }
                    }
                }

                return true;
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Decrypt failed:\n\n" + ex.Message);
                return false;
            }
        }
    }
}
