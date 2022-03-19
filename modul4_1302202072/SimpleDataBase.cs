using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302202072
{
    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }
        public void AddNewData<T>(T data, DateTime time)
        {
            dynamic data2 = data;
            dynamic data3 = time;
            this.storedData.Add(data2);
            this.inputDates.Add(time);

        }
        public void PrintAllData()
        {
            for(int i = 0; i < this.storedData.Count; i++)
            {
                Console.Write("DATA {0} berisi: {1}, yang disimpan pada waktu {2}\n", i + 1, this.storedData[i], this.inputDates[i]);
                
            }
        }
    }
}
