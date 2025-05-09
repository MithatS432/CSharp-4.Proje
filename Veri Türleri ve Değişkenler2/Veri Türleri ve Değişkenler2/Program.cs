using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Türleri_ve_Değişkenler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit (otomatik) dönüşüm
            int sayiInt = 42;
            long sayiLong = sayiInt; // int -> long otomatik

            float sayiFloat = 10.5f;
            double sayiDouble = sayiFloat; // float -> double otomatik

            Console.WriteLine("Implicit dönüşümler:");
            Console.WriteLine("int -> long: " + sayiLong);
            Console.WriteLine("float -> double: " + sayiDouble);

            // Explicit (manuel) dönüşüm
            double pi = 3.14159;
            int piTam = (int)pi; // double -> int manuel

            long buyukSayi = 100000;
            short kucukSayi = (short)buyukSayi; // long -> short manuel

            Console.WriteLine("\nExplicit dönüşümler:");
            Console.WriteLine("double -> int: " + piTam);
            Console.WriteLine("long -> short: " + kucukSayi);

            // string'ten sayıya dönüşüm
            string strSayi = "123";
            int parsedSayi = int.Parse(strSayi); // string -> int
            Console.WriteLine("\nString to int parse: " + parsedSayi);

            // sayıyı string'e çevirme
            int yas = 25;
            string yasStr = yas.ToString(); // int -> string
            Console.WriteLine("int to string: " + yasStr);
        }
    }
}
