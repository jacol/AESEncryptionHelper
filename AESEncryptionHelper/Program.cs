using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace AESEncryptionHelper
{
    class Program
    {
        public static void Main()
        {
            try
            {
                string AES_KEY_string = "U!ĎtË 2.,ÔÇ–ĂČ™›1ŁŹÁC‹[nÍëb";
                string AES_IV_string = "-âUŁ±ţˇĺ±đ÷í2˙Ę";

                byte[] AES_KEY = Encoding.Default.GetBytes(AES_KEY_string);
                byte[] AES_IV = Encoding.Default.GetBytes(AES_IV_string);

                string original = "Here is some data to encrypt!";
                
                RijndaelManaged myRijndael = new RijndaelManaged();
                
                
                byte[] encrypted = EncryptionManager.EncryptStringToBytes(original, AES_KEY, AES_IV);
                string roundtrip = EncryptionManager.DecryptStringFromBytes(encrypted, AES_KEY, AES_IV);

                string cipherText = EncryptionManager.EncryptString(original, AES_KEY, AES_IV);
                string roundtrip2 = EncryptionManager.DecryptString(cipherText, AES_KEY, AES_IV);
                
                Console.WriteLine("Original:   {0}", original);
                Console.WriteLine("Round Trip: {0}", roundtrip);
                Console.WriteLine("Round Trip2: {0}", roundtrip2);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }
    }
}
