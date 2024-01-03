using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslemOrnek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metin türündeki verilerin okunması
            String veri;
            veri = File.ReadAllText("d:\\abc.txt");//abc.txt dosyasının tamamını oku
            Console.WriteLine(veri);
        }
    }
}
