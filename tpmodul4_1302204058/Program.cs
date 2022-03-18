using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4_1302204058
{
    public class ClassMain
    {
        public static void Main(string[] args)
        {
            DataGeneric<string> dataGeneric = new DataGeneric<string>("1302204058");
            dataGeneric.PrintData();
        }
    }

    public class DataGeneric<T>
    {
        private T Data;

        public DataGeneric(T Data)
        {
            this.Data = Data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + Data);
        }
    }
}