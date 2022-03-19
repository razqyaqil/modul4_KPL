using System;

namespace modul4_1302202072 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            penjumlahan<double> jumlah = new penjumlahan<double>();
            Console.WriteLine(jumlah.PenjumlahanTigaAngka<double>(1.3, 0.2, 2.0));

        }
    }
}
