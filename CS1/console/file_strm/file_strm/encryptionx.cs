using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Text.RegularExpressions;


namespace file_strm
{
    class encryptionx
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a data: ");
            string p = Console.ReadLine();
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes("welcome1");

            byte[] byteArray = Encoding.ASCII.GetBytes(p);
            MemoryStream stream = new MemoryStream(byteArray);

            RijndaelManaged RMCrypto = new RijndaelManaged();

            CryptoStream cs = new CryptoStream(stream, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Read);

            StreamReader reader = new StreamReader(cs);
            string text = reader.ReadToEnd();
            Console.WriteLine("data is : " + text);
        }
    }
}
