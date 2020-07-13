using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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

            byte[] toEncryptBytes = String8ToByte(toEncrypt);
            byte[] keyBytes = String8ToByte(key);

            symmetricAlgorithm.Key = keyBytes;
            symmetricAlgorithm.Mode = cipherMode;
            symmetricAlgorithm.Padding = paddingMode;

            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);

            cryptoStream.Write(toEncryptBytes, 0, toEncryptBytes.Length);
            cryptoStream.Close();

            byte[] encryptedBytes = memoryStream.ToArray();
            memoryStream.Close();

            return ByteToString64(encryptedBytes);
        }
        public static string DecryptString(string toDecrypt, string key, CipherMode cipherMode, PaddingMode paddingMode)
        {
            InitializeSymmetricAlgorithm();

            byte[] toEncrypBytes = String64ToByte(toDecrypt);
            byte[] keyBytes = String8ToByte(key);

            symmetricAlgorithm.Key = keyBytes;
            symmetricAlgorithm.Mode = cipherMode;
            symmetricAlgorithm.Padding = paddingMode;

            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);

            cryptoStream.Write(toEncrypBytes, 0, toEncrypBytes.Length);
            cryptoStream.Close();

            byte[] decryptedBytes = memoryStream.ToArray();
            memoryStream.Close();

            return ByteToString8(decryptedBytes);
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

        private static string ByteToString8(byte[] bytes)
        {
            return UTF8Encoding.UTF8.GetString(bytes);
        }
        private static byte[] String8ToByte(string toTransformString)
        {
            return UTF8Encoding.UTF8.GetBytes(toTransformString);
        }
        private static string ByteToString64(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }
        private static byte[] String64ToByte(string toTransformString)
        {
            return Convert.FromBase64String(toTransformString);
        }
    }
}
