﻿using System;
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
            String nama = "Deva";
            HaloGeneric.SapaUser<string>(ref nama);
            DataGeneric<string> dataGeneric = new DataGeneric<string>("1302204058");
            dataGeneric.PrintData();
        }
    }

    class HaloGeneric
    {
        public static void SapaUser<T>(ref T nama)
        {
            Console.WriteLine("Halo user " + nama);
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
