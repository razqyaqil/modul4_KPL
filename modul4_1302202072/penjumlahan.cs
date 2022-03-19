using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302202072
{
    public class penjumlahan<T>
    {

        private T x;
        private T y;
        private T z;

        public dynamic PenjumlahanTigaAngka<T>( T x,  T y, T z)
        {
            dynamic temp = 0;
            temp = temp + x;
            temp = temp + y;
            temp = temp + z;
            return temp; 
        }
    }
}
