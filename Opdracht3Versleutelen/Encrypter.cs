using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht3Versleutelen
{
    class Encrypter
    {
        private const string initialKey = "0123456789abcdef";
        private const CipherMode initialCipherMode = CipherMode.CBC;
        private const PaddingMode initialPaddingMode = PaddingMode.PKCS7;

        private static SymmetricAlgorithm symmetricAlgorithm;

        public static string GetInitialKey()
        {
            return initialKey;
        }
        public static Object GetInitialCipherMode()
        {
            return initialCipherMode;
        }
        public static Object GetInitialPaddingMode()
        {
            return initialPaddingMode;
        }

        public static void RunCipherModesThoughLambda(Action<object> lamba)
        {
            foreach (CipherMode cipherMode in Enum.GetValues(typeof(CipherMode)))
            {
                lamba(cipherMode);
            }
        }
        public static void RunPaddingModesThoughLambda(Action<object> lamba)
        {
            foreach (PaddingMode paddingMode in Enum.GetValues(typeof(PaddingMode)))
            {
                lamba(paddingMode);
            }
        }

        private static void InitializeSymmetricAlgorithm()
        {
            if (symmetricAlgorithm == null)
            {
                symmetricAlgorithm = Rijndael.Create();
            }
        }

        public static string EncryptString(string toEncrypt, string key, CipherMode cipherMode, PaddingMode paddingMode)
        {
            InitializeSymmetricAlgorithm();

            Byte[] toEncrypBytes = Encoding.UTF8.GetBytes(toEncrypt);
            Byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            symmetricAlgorithm.Key = keyBytes;
            symmetricAlgorithm.Mode = cipherMode;
            symmetricAlgorithm.Padding = paddingMode;

            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);

            cryptoStream.Write(toEncrypBytes, 0, toEncrypBytes.Length);
            cryptoStream.Close();

            Byte[] encryptedBytes = memoryStream.ToArray();
            memoryStream.Close();

            return Encoding.UTF8.GetString(encryptedBytes);
        }
        public static string DecryptString(string toDecrypt, string key, CipherMode cipherMode, PaddingMode paddingMode)
        {
            InitializeSymmetricAlgorithm();

            Byte[] toEncrypBytes = Encoding.UTF8.GetBytes(toDecrypt);
            Byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            symmetricAlgorithm.Key = keyBytes;
            symmetricAlgorithm.Mode = cipherMode;
            symmetricAlgorithm.Padding = paddingMode;

            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);

            cryptoStream.Write(toEncrypBytes, 0, toEncrypBytes.Length);
            cryptoStream.Close();

            Byte[] decryptedBytes = memoryStream.ToArray();
            memoryStream.Close();

            return Encoding.UTF8.GetString(decryptedBytes);
        }

        internal static string EncryptString(string toEncrypt, string key, object cipherMode, object paddingMode)
        {
            if (typeof(CipherMode).IsInstanceOfType(cipherMode) && typeof(PaddingMode).IsInstanceOfType(paddingMode))
            {
                return EncryptString(toEncrypt, key, (CipherMode)cipherMode, (PaddingMode)paddingMode);
            }
            return null;
        }
        internal static string DecryptString(string toDecrypt, string key, object cipherMode, object paddingMode)
        {
            if (typeof(CipherMode).IsInstanceOfType(cipherMode) && typeof(PaddingMode).IsInstanceOfType(paddingMode))
            {
                return DecryptString(toDecrypt, key, (CipherMode)cipherMode, (PaddingMode)paddingMode);
            }
            return null;
        }
        
    }
}
