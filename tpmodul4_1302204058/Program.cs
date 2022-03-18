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
            String nama = "Deva";
            HaloGeneric.SapaUser<string>(ref nama);
        }
    }

    class HaloGeneric
    {
        public static void SapaUser<T>(ref T nama)
        {
            Console.WriteLine("Halo user " + nama);
        }
    }
}