using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumleri
{
    internal class Program
    {
        

         static void Main(string[] args)
        {
            string i = "----------------------------------";
            while (true)
            {
                Console.Write("1-Şifrele\n2-Şifre Çöz\nCevabınız: ");
                string cevap = Console.ReadLine();
                if (cevap == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Şifrelemek istediğin metini gir: ");
                    string x = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(string.Format("{1}\nŞifreli metin: {0}\n{1}",sifrele(x),i));
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (cevap == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Şifresini çözmek istediğin metini gir: ");
                    string y = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(string.Format("{1}\nŞifresi çözülmüş metin: {0}\n{1}", sifreCoz(y), i));
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    Console.WriteLine("Geçerli bir seçenek seçiniz");
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
        static string sifrele(string cevap)
        {
           List<char> list = new List<char>();
            int karakter;
            char sifreliCh;
           foreach (char c in cevap)
            {
                karakter = c;
                karakter += 5;
                sifreliCh = (char)karakter;
                list.Add(sifreliCh);
            }
           return string.Join("", list);
        }
        static string sifreCoz(string cevap)
        {
            List<char> list = new List<char>();
            int karakter;
            char sifreliCh;
            foreach (char c in cevap)
            {
                karakter = c;
                karakter -= 5;
                sifreliCh = (char)karakter;
                list.Add(sifreliCh);
            }
            return string.Join("", list);
        }



    }
}