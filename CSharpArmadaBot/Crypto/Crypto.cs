using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace CSharpArmadaBot.Crypto
{
    class Crypto
    {
        public static string GetExecutingFileHash()
        {
            return MD5(ASCIIEncoding.ASCII.GetString(GetSelfBytes()));
        }

        private static string MD5(string input)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] originalBytes = ASCIIEncoding.Default.GetBytes(input);
            byte[] encodedBytes = md5.ComputeHash(originalBytes);

            return BitConverter.ToString(encodedBytes).Replace("-", "");
        }

        private static byte[] GetSelfBytes()
        {
            string path = Application.ExecutablePath;

            FileStream running = File.OpenRead(path);

            byte[] exeBytes = new byte[running.Length];
            running.Read(exeBytes, 0, exeBytes.Length);

            running.Close();

            return exeBytes;
        }
        public static bool VerifySignedHash(byte[] DataToVerify, byte[] SignedData)
        {
            try
            {
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();
                RSAParameters Key = RSAalg.ExportParameters(false);
                Key.Modulus = Convert.FromBase64String("umqeLUNOZ4+sbFW1SpkxmGebpVjSXt8eLJ/aZGNlPQIKH40eSNQZwS2AaKseNysaimfA7WojY4JfdCipiON2TGcey6qDzOwS5novcsQwR4OxHdHn7Dv9kD/WNlERW7Q7nwGYMmjL0XTK8cTjLKgB8hiS1wsXZFWbsCWTRiA+Kis=");
                RSAalg.ImportParameters(Key);
                return RSAalg.VerifyData(DataToVerify, new SHA256CryptoServiceProvider(), SignedData);

            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return false;
            }
        }
    }
}
