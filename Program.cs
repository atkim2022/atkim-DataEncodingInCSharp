using System;

namespace atkim_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch; 
            ch = 'A'; 
            Console.WriteLine($"ch is storing the value of {ch}");

            int ch_decimal; 
            ch_decimal = ch; 
            Console.WriteLine($"The decimal value of ch is: {ch_decimal}");

            int toConvert;
            Console.Write("Enter an integer: ");
            toConvert = int.Parse(Console.ReadLine());

            char asChar;
            asChar = (char)toConvert; 
            Console.WriteLine($"The integer {toConvert} cast to a char is '{asChar}'");

            char a;
            a = (char)('A' + 1);
            Console.WriteLine($"'A' + 1 = '{a}'");

            char b;
            b = (char)('Z' + 3);
            Console.WriteLine($"'Z' + 3 = '{b}'");

// Khoor#Zruog$
            
            char c;
            c = (char)('K' - 3);
            Console.WriteLine($"'K' - 3 = '{c}'");

            char d;
            d = (char)('h' - 3);
            Console.WriteLine($"'h' - 3 = '{d}'");

            char e;
            e = (char)('o' - 3);
            Console.WriteLine($"'o' - 3 = '{e}'");

            char f;
            f = (char)('r' - 3);
            Console.WriteLine($"'r' - 3 = '{f}'");
           
            char g;
            g = (char)('#' - 3);
            Console.WriteLine($"'#' - 3 = '{g}'");

            char h;
            h = (char)('Z' - 3);
            Console.WriteLine($"'Z' - 3 = '{h}'");

            char i;
            i = (char)('u' - 3);
            Console.WriteLine($"'u' - 3 = '{i}'");

            char j;
            j = (char)('g' - 3);
            Console.WriteLine($"'g' - 3 = '{j}'");

            char k;
            k = (char)('$' - 3);
            Console.WriteLine($"'$' - 3 = '{k}'");
           
        
        }
    }
}
