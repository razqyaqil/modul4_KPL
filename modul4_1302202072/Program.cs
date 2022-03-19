using System;

namespace modul4_1302202072 // Note: actual namespace depends on the project name.
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
        }
    }
}
