using System;
using System.Collections.Generic;
using System.IO;

namespace Pdf2Db
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Lütfen işlem yapılacak klasörü girin");

                string path = Console.ReadLine();

                Console.WriteLine("Arama yapılıyor, lütfen bekleyiniz.");

                string[] filePaths = Directory.GetFiles(path, "*.pdf", SearchOption.AllDirectories);

                Console.WriteLine($"{filePaths.Length} adet PDF dosyası bulundu");

                Console.WriteLine();
            }
        }

        static string ReadPdfContent(string path)
        {
            // bu bölümde pdf dosyası okunacak ve içerik dönülecek.

            return "";
        }

    }
}
