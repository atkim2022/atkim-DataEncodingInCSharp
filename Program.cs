using System;

namespace atkim_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {            
            string filePath = args[0];
            Console.WriteLine($"Loading '{filePath}'");

            string message;
            message = System.IO.File.ReadAllText(filePath);
            Console.WriteLine($"The encrypted message is: '{message}'");


            int shift;
            shift = 1;  
            while (shift <= 10)
            { 
            Cipher cipher;
            cipher = new Cipher (shift);
            string decrypted;
            decrypted = cipher.Decrypt(message);
            Console.WriteLine($"The decrypted message is: '{decrypted}'");
            shift++; 
            }

        }
    }
}
