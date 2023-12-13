using System;
using System.Text;

namespace OOPLaba3_2
{
    internal class Program
    {
        public static int Key = 102;

        static void Main(string[] args)
        {
            // кодіровка
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть рядок, щоб його зашифрувати = ");
            string InputString;
            InputString = Console.ReadLine();

            Console.WriteLine($"Початкові дані: {InputString}\n");

            Console.WriteLine($"Зашифрований рядок: {Convert.ToBase64String(Encrypt(InputString))}\n");

            Console.WriteLine($"Розшифрований рядок: {Encoding.UTF8.GetString(Decrypt(Encoding.UTF8.GetBytes(InputString)))}\n");
            Console.ReadLine();
        }

        public static byte[] Encrypt(string InputString)
        {
            byte[] DataEncrypt = Encoding.UTF8.GetBytes(InputString);
            for (int i = 0; i < DataEncrypt.Length; i++)
            {
                DataEncrypt[i] = (byte)(DataEncrypt[i] ^ Key);
            }
            return DataEncrypt;
        }

        public static byte[] Decrypt(byte[] DataEncrypt)
        {
            byte[] DataDecrypt = Convert.FromBase64String(Convert.ToBase64String(DataEncrypt));
            for (int i = 0; i < DataDecrypt.Length; i++)
            {
                DataDecrypt[i] = (byte)(DataDecrypt[i] ^ Key);
            }
            return DataEncrypt;
        }
    }
}
