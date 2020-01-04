using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace CryptWinForm
{
    public static class CryptoUtils
    {
        public static byte[] DeriveKey(string password, byte[] salt, string hashName = "SHA1", int pwdIteration = 2, int keySize = 256)
        {
            byte[] pwd = Encoding.Unicode.GetBytes(password);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(pwd, salt, hashName, pwdIteration);
            byte[] res = pdb.GetBytes(keySize / 8);
            ClearBytes(pwd);
            //ClearBytes(salt);
            return res;
        }
        public static byte[] AesEncrypt(byte[] plainText, Aes mAes)
        {
            if (plainText == null || plainText.Length <= 0) throw new ArgumentException("plainText");
            if (mAes.Key == null || mAes.Key.Length <= 0) throw new ArgumentException("Key");
            if (mAes.IV == null || mAes.IV.Length <= 0) throw new ArgumentException("IV");

            byte[] encrpyted = null;

            // Create an encryptor to perform the stream transform.
            using (ICryptoTransform encryptor = mAes.CreateEncryptor(mAes.Key, mAes.IV))
            {
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(plainText, 0, plainText.Length);
                        csEncrypt.FlushFinalBlock();
                        encrpyted = msEncrypt.ToArray();
                        msEncrypt.Close();
                        csEncrypt.Close();
                    }
                }
            }
            return encrpyted;
        }
        public static byte[] AesDecrypt(byte[] cipherText, Aes mAes)
        {
            if (cipherText == null || cipherText.Length <= 0) throw new ArgumentException("cipherText");
            if (mAes.Key == null || mAes.Key.Length <= 0) throw new ArgumentException("Key");
            if (mAes.IV == null || mAes.IV.Length <= 0) throw new ArgumentException("IV");

            byte[] buffer = new byte[cipherText.Length];
            int ByteCount = 0;

            // Create an decryptor to perform the stream transform.
            using (ICryptoTransform decryptor = mAes.CreateDecryptor(mAes.Key, mAes.IV))
            {
                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            ByteCount = csDecrypt.Read(buffer, 0, buffer.Length);
                            msDecrypt.Close();
                            csDecrypt.Close();
                        }
                    }
                }
            }

            //get the actual size of decrpyted
            byte[] decrpytedBytes = new byte[ByteCount];
            Array.Copy(buffer, 0, decrpytedBytes, 0, decrpytedBytes.Length);
            ClearBytes(buffer);

            return decrpytedBytes;
        }
        public static byte[] CreateRandomSalt(int length)
        {
            byte[] randBytes;
            if (length >= 1)
            {
                randBytes = new byte[length];
            }
            else
            {
                randBytes = new byte[1];
            }
            RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
            rand.GetBytes(randBytes);
            return randBytes;
        }
        public static void ClearBytes(byte[] buffer)
        {
            if (buffer == null)
            {
                throw new ArgumentException("buffer");
            }
            for (int x = 0; x < buffer.Length; x++)
            {
                buffer[x] = 0;
            }
        }
        public static bool RsaGenerateKey(out string publicKey, out string privateKey)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024))
                {
                    publicKey = rsa.ToXmlString(false);
                    privateKey = rsa.ToXmlString(true);
                }
                return true;
            }
            catch(CryptographicException ce)
            {
                publicKey = null;
                privateKey = null;
                return false;
            }
        }
        public static byte[] RsaEncrypt(byte[] plainText, string publicKey, bool DoOAEPPadding = false)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider Rsa = new RSACryptoServiceProvider(1024))
                {
                    Rsa.FromXmlString(publicKey);
                    encryptedData = Rsa.Encrypt(plainText, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public static byte[] RsaDecrypt(byte[] cipherText, string privateKey, bool DoOAEPPadding = false)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider Rsa = new RSACryptoServiceProvider(1024))
                {
                    Rsa.FromXmlString(privateKey);
                    decryptedData = Rsa.Decrypt(cipherText, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }

        }
        public static byte[] RsaSign(byte[] data, string privateKey)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    byte[] hash;
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        hash = sha256.ComputeHash(data);
                    }
                    rsa.FromXmlString(privateKey);
                    RSAPKCS1SignatureFormatter RSAFormatter = new RSAPKCS1SignatureFormatter(rsa);
                    RSAFormatter.SetHashAlgorithm("SHA256");
                    byte[] SignedHash = RSAFormatter.CreateSignature(hash);
                    return SignedHash;
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public static bool RsaVerify(byte[] data, byte[] signedHash, string publicKey)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    //compute data to hash
                    byte[] hash;
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        hash = sha256.ComputeHash(data);
                    }
                    rsa.FromXmlString(publicKey);
                    //compare
                    RSAPKCS1SignatureDeformatter RSADeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                    RSADeformatter.SetHashAlgorithm("SHA256");
                    if (RSADeformatter.VerifySignature(hash, signedHash))
                    {
                        return true; //verifyed!
                    }
                    return false; //not verifyed
                }
            }
            catch(CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
