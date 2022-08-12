using System;
using System.Collections.Generic;
using System.IO;

namespace Pdf2Db
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            string[] filePaths = Directory.GetFiles(path, "*.pdf", SearchOption.AllDirectories);

            Console.WriteLine($"{filePaths.Length} adet PDF dosyası bulundu");

            Console.ReadKey();
        }

    }
}
