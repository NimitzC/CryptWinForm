using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace CryptWinForm
{
    public static class FileCrypto
    {
        public const string SALT = "zengzhaoyu";
        public static bool AesEncrypt(string inputPath, string outputPath, string password)
        {
            //generate pwd if empty
            if (string.IsNullOrEmpty(password)) password = "1234567890";

            FileStream fin = null;
            FileStream fout = null;

            try
            {
                using (Aes aes = Aes.Create())
                {
                    fin = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
                    fout = new FileStream(outputPath, FileMode.Create, FileAccess.Write);

                    //derive key
                    byte[] salt = Encoding.ASCII.GetBytes(SALT);
                    aes.Key = CryptoUtils.DeriveKey(password, salt);

                    //read plainText from file
                    byte[] plainText = new byte[fin.Length];
                    fin.Read(plainText, 0, plainText.Length);

                    //Encrypt
                    byte[] encrypted = CryptoUtils.AesEncrypt(plainText, aes);

                    //write auto generated IV to file
                    fout.Write(aes.IV, 0, aes.IV.Length);

                    //write cipherText to file
                    fout.Write(encrypted, 0, encrypted.Length);
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("FileCrypto.AesEncrypt Wrong!");
                return false;
            }
            finally 
            {
                if (fin != null) fin.Close();
                if (fout != null) fout.Close();
            }
        }
        public static bool AesDecrypt(string inputPath, string outputPath, string password)
        {
            //generate pwd if empty
            if (string.IsNullOrEmpty(password)) password = "1234567890";

            FileStream fin = null;
            FileStream fout = null;

            try
            {
                using (Aes aes = Aes.Create())
                {
                    fin = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
                    fout = new FileStream(outputPath, FileMode.Create, FileAccess.Write);

                    byte[] salt = Encoding.ASCII.GetBytes(SALT);
                    aes.Key = CryptoUtils.DeriveKey(password, salt);

                    //read IV from file
                    byte[] IVBytes = new byte[16];
                    fin.Read(IVBytes, 0, IVBytes.Length);

                    //read cipherText from file
                    byte[] encrypted = new byte[fin.Length - IVBytes.Length];
                    fin.Read(encrypted, 0, encrypted.Length);

                    //decrypted
                    aes.IV = IVBytes;
                    byte[] decrypted = CryptoUtils.AesDecrypt(encrypted, aes);

                    //write to a new file
                    fout.Write(decrypted, 0, decrypted.Length);
                    return true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("FileCrypto.AesDecrypt Wrong!");
                return false;
            }
            finally
            {
                if (fin != null) fin.Close();
                if (fout != null) fout.Close();
            }
        }
        public static bool RsaEncrypt(string inputPath, string outputPath, string publicKey)
        {
            FileStream fin = null;
            FileStream fout = null;
            try
            {
                fin = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
                fout = new FileStream(outputPath, FileMode.Create, FileAccess.Write);

                //read plainText from file
                byte[] plainText = new byte[fin.Length];
                fin.Read(plainText, 0, plainText.Length);

                //RsaEncrypt
                byte[] encrpyted = CryptoUtils.RsaEncrypt(plainText, publicKey);

                //write encrpyted to file
                fout.Write(encrpyted, 0, encrpyted.Length);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("FileCrypto.RsaEncrypt() Wrong");
                return false;
            }
            finally
            {
                if (fin != null) fin.Close();
                if (fout != null) fout.Close();
            }
            
        }
        public static bool RsaDecrypt(string inputPath, string outputPath, string privateKey)
        {
            FileStream fin = null;
            FileStream fout = null;
            try
            {
                fin = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
                fout = new FileStream(outputPath, FileMode.Create, FileAccess.Write);

                //read cipherText from file
                byte[] cipherText = new byte[fin.Length];
                fin.Read(cipherText, 0, cipherText.Length);

                //RsaEncrypt
                byte[] decrpyted = CryptoUtils.RsaDecrypt(cipherText, privateKey);

                //write decrpyted to file
                fout.Write(decrpyted, 0, decrpyted.Length);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("Filecrypto.RsaDecrypt Wrong!");
                return false;
            }
            finally
            {
                if (fin != null) fin.Close();
                if (fout != null) fout.Close();
            }
        }
        public static bool WriteBytesToFile(string path, byte[] bytes)
        {
            FileStream fout = null;
            try
            {
                fout = new FileStream(path, FileMode.Create, FileAccess.Write);
                fout.Write(bytes, 0, bytes.Length);
                return true;
            }
            catch (IOException ie)
            {
                return false;
            }
            finally
            {
                if(fout!=null) fout.Close();
            }
        }
        public static byte[] ReadBytesFromFile(string path)
        {
            FileStream fin = null;
            try
            {
                fin = new FileStream(path, FileMode.Open, FileAccess.Read);
                byte[] data = new byte[fin.Length];
                fin.Read(data, 0, data.Length);
                return data;
            }
            catch (IOException ie)
            {
                Console.WriteLine("open File failed");
                return null;
            }
            finally
            {
                if (fin != null) fin.Close();
            }
        }
        public static bool RsaWriteKeyToFile(string path, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            if (!WriteBytesToFile(path, keyBytes))
            {
                Console.WriteLine("Write Bytes To File Wrong");
                return false;
            }
            return true;
        }
        public static string RsaReadKeyFromFile(string path)
        {
            byte[] keyBytes = ReadBytesFromFile(path);
            return Encoding.UTF8.GetString(keyBytes);
        }
        public static bool RsaGenerateKeyToFile(string publicKeyPath, string privateKeyPath)
        {
            string publicKey;
            string privateKey;
            try
            {
                CryptoUtils.RsaGenerateKey(out publicKey, out privateKey);
                if(!RsaWriteKeyToFile(publicKeyPath, publicKey))
                {
                    Console.WriteLine("Write PublicKey Failed");
                    return false;
                }
                if(!RsaWriteKeyToFile(privateKeyPath, privateKey))
                {
                    Console.WriteLine("Write PrivateKey Failed");
                    return false;
                }
                return true;
            }
            catch
            {
                Console.WriteLine("RsaGenerateKeyToFile failed");
                return false;
            }
            
        }
        public static bool RsaSign(string inputPath, string outputPath, string privateKey)
        {

            FileStream fin = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
            FileStream fout = new FileStream(outputPath, FileMode.Create, FileAccess.Write);

            try
            {
                //read Text from file
                byte[] text = new byte[fin.Length];
                fin.Read(text, 0, text.Length);

                //RsaSign
                byte[] signedHash = CryptoUtils.RsaSign(text, privateKey);
                Console.WriteLine(signedHash.Length);

                //write Sign to file
                fout.Write(signedHash, 0, signedHash.Length);

                //write Text to file
                fout.Write(text, 0, text.Length);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("FileCrypto.RsaSign Wrong!");
                return false;
            }
            finally
            {
                fin.Close();
                fout.Close();
            }
        }
        public static bool RsaVerify(string inputPath, string publicKey)
        {
            FileStream fin = new FileStream(inputPath, FileMode.Open, FileAccess.Read);

            try
            {
                //read signedHash from file
                byte[] signedHash = new byte[128];
                fin.Read(signedHash, 0, signedHash.Length);

                //read Text from file
                byte[] text = new byte[fin.Length - signedHash.Length];
                fin.Read(text, 0, text.Length);
                return CryptoUtils.RsaVerify(text, signedHash, publicKey);
            }
            catch(Exception e)
            {
                Console.WriteLine("FileCrypto.RsaVerify Wrong!");
                return false;
            }
            finally
            {
                fin.Close();
            }
        }
    }
}
