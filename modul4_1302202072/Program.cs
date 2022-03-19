using System;

namespace modul4_1302202072 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SimpleDataBase<int> dataBase = new SimpleDataBase<int>();
            dataBase.AddNewData(12, DateTime.Now);
            dataBase.AddNewData(34, DateTime.Now);
            dataBase.AddNewData(56, DateTime.Now);
            dataBase.PrintAllData();    

            penjumlahan<double> jumlah = new penjumlahan<double>();
            Console.WriteLine(jumlah.PenjumlahanTigaAngka<double>(1.3, 0.2, 2.0));


        }
    }
}
